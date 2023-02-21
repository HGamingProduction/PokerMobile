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

public class CreateTableButtonScripts : MonoBehaviour
{
    public static string responceServer;
    public Slider slider1;
    public Slider slider2;
    private static void Ws_OnMessage(object sender, MessageEventArgs e)
    {
        Debug.Log("CheckOpen: " + e.Data);
        responceServer = e.Data;
    }
    public async void CreateTabless()
    {
        MainWebSocket.ws.OnMessage += Ws_OnMessage;

        MainWebSocket.ws.Connect();

        string? cryptoTypes;
        float sliderValue1 = slider1.value;
        float sliderValue2 = slider2.value;
        if (SelectedTypeGameScripts.selectedOption == "GAME")
        {
            cryptoTypes = null;
        }
        else
        {
            cryptoTypes = SelectedCryptoScripts.selectedOption;
        }
        var jsona = new CreatePokerTable
        {
            eventType = "create_table",
            createPokerTable = new CreatePokerTable { seatsNumber = Convert.ToInt32(sliderValue1), bigBlind = Convert.ToInt32(sliderValue2), currencyType = SelectedTypeGameScripts.selectedOption, cryptoType = cryptoTypes }
        };

        string message = JsonConvert.SerializeObject(jsona);

        MainWebSocket.ws.Send(message);



    }
}

public class CreatePokerTable : CreateTableButtonRoot
{
    public int seatsNumber { get; set; }
    public int bigBlind { get; set; }
    public string currencyType { get; set; }
    public string? cryptoType { get; set; }
}

public class CreateTableButtonRoot
{
    public string eventType { get; set; }
    public CreatePokerTable createPokerTable { get; set; }
}


