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

public class ExitAccountScripts : MonoBehaviour
{
    public Button ExitButton;
    private static void Ws_OnMessage(object sender, MessageEventArgs e)
    {
        Debug.Log("EXITACCOUNT: " + e.Data);
    }
    public async void ExitAccount()
    {
        WebSocket ws = new WebSocket(Glob.websocketurl);
        ws.OnMessage += Ws_OnMessage;
        ws.Connect();

        var jsona = new ExitAssets
        {
            eventType = "logout"
        };

        string message = JsonConvert.SerializeObject(jsona);

        ws.Send(message);

        SceneManager.LoadScene(0);
    }
    public async void ScreenCreateTable()
    {
        SceneManager.LoadScene(4);
    }
    public async void ScreenTables()
    {
        SceneManager.LoadScene(1);
    }
    public async void ScreenProfile()
    {
        SceneManager.LoadScene(5);
    }
}
public class ExitAssets
{

    public string eventType { get; set; }

}