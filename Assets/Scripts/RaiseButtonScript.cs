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


public class RaiseButtonScript : MonoBehaviour
{
    
   /* public static string responce1;
    public static int a = 0;
    public static int i = 0;
    public static int b = 0;
    public static int g = 0;*/
    private static void Ws_OnMessage(object sender, MessageEventArgs e)
    {
        Debug.Log("OpenRaise: " + e.Data);
       /* responce1 = e.Data;
        var currency = JsonConvert.DeserializeObject<Root1>(responce1);

        for (i = 0; a == 2; g++)
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
        }

        Debug.Log(currency.seats[b].userChips);

        Debug.Log("123123");*/
    }

    public async void RaiseTableAction()
    {

        


        MainWebSocket.ws.OnMessage += Ws_OnMessage;

        MainWebSocket.ws.Connect();

        var jsona = new RaiseTableAssetsMain
        {
            eventType = "action",
            action = new RaiseTableAssetsMain { type = "raise", bet = RaiseButtonPopUpScript.ValueBet }
        };

        string message = JsonConvert.SerializeObject(jsona);

        MainWebSocket.ws.Send(message);


    }








}
public class RaiseTableAssets
{

    public new RaiseTableAssetsMain action { get; set; }

}
public class RaiseTableAssetsMain : RaiseTableAssets
{
    public string eventType { get; set; }

    public string type { get; set; }

    public int bet { get; set; }




}
/*public class Root1
{


    public List<Seat1> seats { get; set; }
}


public class Seat1
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

*/