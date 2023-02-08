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

public class LeaveTable : MonoBehaviour
{
    private static void Ws_OnMessage(object sender, MessageEventArgs e)
    {
        Debug.Log("Open: " + e.Data);
    }

    public async void LeaveTablePoker()
    {
        
        WebSocket ws = new WebSocket(Glob.websocketurl);

        ws.OnMessage += Ws_OnMessage;

        ws.Connect();

        var jsona = new LeaveTableAssets
        {
            eventType = "leave_table",
            
        };

        string message = JsonConvert.SerializeObject(jsona);

        ws.Send(message);

        

        SceneManager.LoadScene(1);

        JoinTable.NumberChips = 0;
        JoinTable.NumberChipsTwo = 0;
        JoinTable.CurrentBet = 0;
        JoinTable.CurrentBetTwo = 0;
        JoinTable.CardOnTable1 = " ";
        JoinTable.CardOnTable2 = " ";
        JoinTable.CardOnTable3 = " ";
        JoinTable.CardOnTable4 = " ";
        JoinTable.CardOnTable5 = " ";
    }



}
public class LeaveTableAssets
{

    public string eventType { get; set; }

}