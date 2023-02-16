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

public class GameMoment : MonoBehaviour
{
    public static string responce;
    private static void Ws_OnMessage(object sender, MessageEventArgs e)
    {
        Debug.Log("Open11: " + e.Data);
        responce = e.Data;


        /*   for (i = 0; a == 2; g++)
           {
               if (currency.seats[i].userId == 26)
               {
                   a = 2;
                   b = i;
                   break;
               }
              else
               {

                   i++;
               }
           }*/
        /*var currency = JsonConvert.DeserializeObject<Root>(responce);
        int a = 0;
        int i = 0;
        int b = 0;
        int g = 0;

        while (i < 4)
        {
            if (currency.seats[i].userId == 26)
            {

                b = i;

                break;
                Debug.Log("OTVETKA");
            }
            else
            {
                Debug.Log("HYITA");
                i++;
            }

        }

        Debug.Log(currency.seats[b].userChips);



        Debug.Log("123123");
*/
    }
     
    
    // Start is called before the first frame update
    void Start()
    {


        MainWebSocket.ws.OnMessage += Ws_OnMessage;

        MainWebSocket.ws.Connect();

       
    }

    // Update is called once per frame
    void Update()
    {
       

    }
}
public class GameMoments
{

    public new GameMomentMain pokerTable { get; set; }

}
public class GameMomentMain : GameMoments
{
    public string eventType { get; set; }

    public int id { get; set; }

    [Newtonsoft.Json.JsonProperty("Msg")]
    public string msg { get; set; }





}
public class Root
{


    public List<Seat> seats { get; set; }
}


public class Seat
{
    public int? userId { get; set; }
    public int pokerTableId { get; set; }
    public int number { get; set; }
    public object pocket { get; set; }
    public int current_bet { get; set; }
    public bool isDealer { get; set; }
    public bool IsSmallBlind { get; set; }
    public bool isBigBlind { get; set; }
    public bool isCurrent { get; set; }
    public bool isFold { get; set; }
    public string userName { get; set; }
    public int? userChips { get; set; }
    public int raiseMinBet { get; set; }
    public int callBet { get; set; }
    public object lastActionType { get; set; }
    public object lastActionBet { get; set; }
    public List<string> availableActions { get; set; }

}

