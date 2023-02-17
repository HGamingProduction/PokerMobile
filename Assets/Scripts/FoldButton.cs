using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebSocketSharp;
using UnityEngine.UI;
using Newtonsoft.Json;
using System.Net.Http;
using UnityEngine.SceneManagement;


public class FoldButton : MonoBehaviour
{
    public static string responcee;
    private static void Ws_OnMessage(object sender, MessageEventArgs e)
    {
        Debug.Log("FoldOpen: " + e.Data);
        responcee = e.Data;
    }

    public async void FoldTableAction()
    {
        WebSocket ws = new WebSocket(Glob.websocketurl);

        ws.OnMessage += Ws_OnMessage;

        MainWebSocket.ws.OnMessage += Ws_OnMessage;

        MainWebSocket.ws.Connect();

        var jsona = new FoldTableAssetsMain
        {
            eventType = "action",
            action = new FoldTableAssetsMain { type = "fold" }
        };

        string message = JsonConvert.SerializeObject(jsona);

        MainWebSocket.ws.Send(message);

        /*var currency = JsonConvert.DeserializeObject<FoldTableAssetsMain>(responcee);
        Debug.Log(currency.msg);*/
    }








}
public class FoldTableAssets
{

    public new FoldTableAssetsMain action { get; set; }

}
public class FoldTableAssetsMain : FoldTableAssets
{
    public string eventType { get; set; }

    public string type { get; set; }


    [Newtonsoft.Json.JsonProperty("Msg")]
    public string msg { get; set; }

}