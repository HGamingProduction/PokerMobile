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


public class CheckButtonScript : MonoBehaviour
{
    public static string res;
    private static void Ws_OnMessage(object sender, MessageEventArgs e)
    {
        Debug.Log("CheckOpen: " + e.Data);
        res = e.Data;
        

    }

    public async void CheckTableAction()
    {


        MainWebSocket.ws.OnMessage += Ws_OnMessage;

        MainWebSocket.ws.Connect();

        var jsona = new CheckTableAssetsMain
        {
            eventType = "action",
            action = new CheckTableAssetsMain { type = "check" }
        };

        string message = JsonConvert.SerializeObject(jsona);

        MainWebSocket.ws.Send(message);

        Glob.buttonCallBool = false;
        Glob.buttonRaiseBool = false;
        Glob.buttonFoldBool = false;
        Glob.buttonCheckBool = false;
    }








}
public class CheckTableAssets
{

    public new CheckTableAssetsMain action { get; set; }

}
public class CheckTableAssetsMain : CheckTableAssets
{
    public string eventType { get; set; }

    public string type { get; set; }




}
