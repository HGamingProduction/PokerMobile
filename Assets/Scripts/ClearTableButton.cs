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

public class ClearTableButton : MonoBehaviour
{
    private static void Ws_OnMessage(object sender, MessageEventArgs e)
    {
        Debug.Log("Open: " + e.Data);
    }

    public async void ClearTablePoker()
    {
        WebSocket ws = new WebSocket(Glob.websocketurl);

        ws.OnMessage += Ws_OnMessage;

        ws.Connect();

        var jsona = new ClearTableAssetsMain
        {
            eventType = "clean_table",
            pokerTable = new ClearTableAssetsMain { id = 19 }
        };

        string message = JsonConvert.SerializeObject(jsona);

        ws.Send(message);




    }
}
public class ClearTableAssets
{

    public new ClearTableAssetsMain pokerTable { get; set; }

}
public class ClearTableAssetsMain : ClearTableAssets
{
    public string eventType { get; set; }

    public int id { get; set; }




}