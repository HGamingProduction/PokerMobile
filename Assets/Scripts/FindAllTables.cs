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
    public Text NumberOfEnemy;
    public static string responses1;
    public static int TotalTables;
    public static int[] IDTables = new int[9999];
    private static void Ws_OnMessage(object sender, MessageEventArgs e)
    {
        Debug.Log("Open1999999: " + e.Data);
        responses1 = e.Data;



    }

    void Start()
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

    void Update()
    {
        var CurrencyFindAll = JsonConvert.DeserializeObject<Root2>(responses1);
        int i = 0;
        int a = 0;
        int result = 0;
        if (CurrencyFindAll.pokerTables.items[0].id == 1)
        {
            i = CurrencyFindAll.pokerTables.items[0].seatsNumber;
            a = CurrencyFindAll.pokerTables.items[0].emptySeatsNumber;
            result = i - a;

            NumberOfEnemy.text = Convert.ToString(result + "/4");
        }

        if (CurrencyFindAll.pokerTables.items[1].id == 1)
        {
            i = CurrencyFindAll.pokerTables.items[1].seatsNumber;
            a = CurrencyFindAll.pokerTables.items[1].emptySeatsNumber;
            result = i - a;

            NumberOfEnemy.text = Convert.ToString(result + "/4");
        }
        TotalTables = CurrencyFindAll.pokerTables.total;


        int j = CurrencyFindAll.pokerTables.total;
        int ii = 0;
        while (ii < j)
        {
            IDTables[ii] = CurrencyFindAll.pokerTables.items[ii].id;
            ii++;
        }


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
public class Item
{
    public int id { get; set; }
    public int seatsNumber { get; set; }
    public int smallBlind { get; set; }
    public int bigBlind { get; set; }
    public int emptySeatsNumber { get; set; }
    public object creatorId { get; set; }
}

public class PokerTables
{
    public List<Item> items { get; set; }
    public int total { get; set; }
    public int pages { get; set; }
}

public class Root2
{
    public int total { get; set; }
    public string eventType { get; set; }
    public string msg { get; set; }
    public PokerTables pokerTables { get; set; }
}