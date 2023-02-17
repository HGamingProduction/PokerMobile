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

public class DeleteTableScripts : MonoBehaviour
{
    public static string responceServer2;

    private static void Ws_OnMessage(object sender, MessageEventArgs e)
    {
        Debug.Log("CheckOpen: " + e.Data);
        responceServer2 = e.Data;
    }

    public async void DeleteTabless()
    {
        int textIdInt = 0;
        MainWebSocket.ws.OnMessage += Ws_OnMessage;
        MainWebSocket.ws.Connect();
        textIdInt = Convert.ToInt32(JoinTable.IdText);

        var jsona = new DeletePokerTable
        {
            eventType = "delete_table",
            pokerTable = new DeletePokerTable { id = textIdInt }
        };

        string message = JsonConvert.SerializeObject(jsona);

        MainWebSocket.ws.Send(message);
    }




}

public class DeletePokerTable : DeletePokerTableRoot
{
    public int id { get; set; }
}

public class DeletePokerTableRoot
{
    public string eventType { get; set; }
    public DeletePokerTable pokerTable { get; set; }
}

