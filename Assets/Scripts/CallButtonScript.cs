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


public class CallButtonScript : MonoBehaviour
{
    private static void Ws_OnMessage(object sender, MessageEventArgs e)
    {
        Debug.Log("CallOpen: " + e.Data);
    }

    public async void CallTableAction()
    {


        MainWebSocket.ws.OnMessage += Ws_OnMessage;

        MainWebSocket.ws.Connect();

        var jsona = new CallTableAssetsMain
        {
            eventType = "action",
            action = new CallTableAssetsMain { type = "call" }
        };

        string message = JsonConvert.SerializeObject(jsona);

        MainWebSocket.ws.Send(message);

        Glob.buttonCallBool = false;
        Glob.buttonRaiseBool = false;
        Glob.buttonFoldBool = false;
        Glob.buttonCheckBool = false;
    }








}
public class CallTableAssets
{

    public new CallTableAssetsMain action { get; set; }

}
public class CallTableAssetsMain : CallTableAssets
{
    public string eventType { get; set; }

    public string type { get; set; }




}