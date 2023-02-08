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

public class FindAllTables : MonoBehaviour
{
    private static void Ws_OnMessage(object sender, MessageEventArgs e)
    {
        Debug.Log("Open1999999: " + e.Data);
    }
    
    public void Start()
    {
        WebSocket ws = new WebSocket(Glob.websocketurl);   
        
        ws.OnMessage += Ws_OnMessage;

         ws.Connect();

        var jsona = new Jsonaa1
        {
            eventType = "find_all_tables",
            pagination = new Jsonaa1 { page = 1, count = 5 }
        };

        string message = JsonConvert.SerializeObject(jsona);

        ws.Send(message);       

        


    }

}

public class Jsona1
{

    public new Jsonaa1 pagination { get; set; }

}
public class Jsonaa1 : Jsona1
{

    public string eventType { get; set; }

    public int page { get; set; }

    public int count { get; set; }

}