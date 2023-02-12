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


public class JoinTable : MonoBehaviour
    
{
    public static int? NumberChips;
    public static int? NumberChipsTwo;
    public static int? CurrentBet;
    public static int? CurrentBetTwo;
    public static string MyPocket;
    public static string MyPocket2;
    public static string responce11;
    public static string responce111;
    public static string responce1111;
    public static string CardOnTable1;
    public static string CardOnTable2;
    public static string CardOnTable3;
    public static string CardOnTable4;
    public static string CardOnTable5;
    public static string OtherName;
    public static string MyName;
    public static string Suit;
    public static string NumberCard;
    public static string SuitClon;
    public static string NumberCardClon;
    public static int BankOnTable;
    public static string AvaibleOnTable;
    public static string CardOnBoardSuit;
    public static string CardOnBoardSuit1;
    public static string CardOnBoardSuit2;
    public static string CardOnBoardSuit3;
    public static string CardOnBoardSuit4;
    public static string CardOnBoardText;
    public static string CardOnBoardText1;
    public static string CardOnBoardText2;
    public static string CardOnBoardText3;
    public static string CardOnBoardText4;
    public static string ActionTypeMy;
    public static string ActionTypeOther;
    public static string WinsMessage;
    public static int IdOther;
    public static int AvaibleTableOther;
    public static int MyGlobalAvaibleActions;
    public static int FirstGlobalAvaibleActions;
    /*public static string responce;*/
    private static void Ws_OnMessage(object sender, MessageEventArgs e)
    {
        Debug.Log("Open:11111 " + e.Data);
        responce11 = e.Data;
        responce111 = e.Data;
        responce1111 = e.Data;
        /*responce = e.Data;*/

        
        var currency = JsonConvert.DeserializeObject<Root1>(responce11);
        int a = 0;
        int i = 0;
        int b = 0;
        int? g = 0;
        int o = 0;
        
        while (i < 4)
        {
            if (currency.seats[i].userId == Glob.GlobalId)
            {

                b = i;

                break;
                /*Debug.Log("OTVETKA");*/
            }
            else
            {
               /* Debug.Log("HYITA");*/
                i++;
            }

        }
        IdOther = i;
        if (currency.seats[i].lastActionType == null)
        {

            ActionTypeMy = "NUll";

        }
        else
        {
            ActionTypeMy = Convert.ToString(currency.seats[i].lastActionType);
        }
        Debug.Log(currency.seats[i].lastActionType);
        /*Debug.Log(currency.seats[b].userChips);*/
        NumberChips = currency.seats[b].userChips;
        CurrentBet = currency.seats[b].current_bet;
        MyName = currency.seats[b].userName;

        /*Debug.Log(NumberChips);*/
        if (currency.seats[b].pocket[0] == null)
        {
            Suit = "Exception";
            SuitClon = "Exception";
        } else 

        if (currency.seats[b].pocket[0] != null)
        {
            foreach (char v in currency.seats[b].pocket[0])
        {
            Suit = Convert.ToString(v);
            
        }
        foreach (char v in currency.seats[b].pocket[0])
        {
            NumberCard = Convert.ToString(v);
            break;
        }
  
        }
        
        MyPocket = NumberCard;
       
       
        if (currency.seats[b].pocket[1] != null)
        {
            foreach (char v in currency.seats[b].pocket[1])
        {
            SuitClon = Convert.ToString(v);

        }
        foreach (char v in currency.seats[b].pocket[1])
        {
            NumberCardClon = Convert.ToString(v);
            break;
        }
    
        }
       
        MyPocket2 = NumberCardClon;
        






       /* MyPocket2 = currency.seats[b].pocket[1];*/

        while (a < 4)
        {
            if (currency.seats[a].userId != Glob.GlobalId)
            {

               

                break;
               
            }
            else
            {
                 
                a++;
            }

        }
        
        g = currency.seats[a].userId;
        /*umberChipsTwo = currency.seats[a].userChips;
        CurrentBetTwo = currency.seats[a].current_bet;*/
        /*if (currency.seats[1].userId == a)
        {
            AvaibleOnTable = "Exception";
        }*/



        


        if (currency.seats[i].availableActions == null)
        {

            MyGlobalAvaibleActions = 0;

        }
        if (currency.seats[i].availableActions != null)
        {


            MyGlobalAvaibleActions = 1;



        }

        if (currency.seats[a].availableActions == null)
        {

            FirstGlobalAvaibleActions = 0;

        }
        if (currency.seats[a].availableActions != null)
        {


            FirstGlobalAvaibleActions = 1;



        }
        if (currency.seats[a].lastActionType == null)
        {

            ActionTypeOther = "NUll";

        }
        else
        {
            ActionTypeOther = Convert.ToString(currency.seats[a].lastActionType);
        }
        
        Debug.Log(ActionTypeOther);
        if (currency.seats[a] == null)
        {


           


        }
        if (currency.seats[a].userId == g)
        {
            NumberChipsTwo = currency.seats[a].userChips;
            CurrentBetTwo = currency.seats[a].current_bet;
            OtherName = currency.seats[a].userName;
            
        }
        
        

        var currency11 = JsonConvert.DeserializeObject<Action>(responce111);
        if (currency11.game.board == null)
        {

            CardOnTable1 = " ";
            CardOnTable2 = " ";
            CardOnTable3 = " ";
            CardOnTable4 = " ";
            CardOnTable5 = " ";


        }
        BankOnTable = currency11.game.bank;
        


        
        CardOnBoardSuit = "Exception";
        CardOnBoardSuit1 = "Exception";
        CardOnBoardSuit2 = "Exception";
        CardOnBoardSuit3 = "Exception";
        CardOnBoardSuit4 = "Exception";
        foreach (char v in currency11.game.board[0])
            {
            CardOnBoardSuit = Convert.ToString(v);

            }
            foreach (char v in currency11.game.board[0])
            {
            CardOnBoardText = Convert.ToString(v);
                break;
            }
        CardOnTable1 = CardOnBoardText;

        
        foreach (char v in currency11.game.board[1])
        {
            CardOnBoardSuit1 = Convert.ToString(v);

        }
        foreach (char v in currency11.game.board[1])
        {
            CardOnBoardText1 = Convert.ToString(v);
            break;
        }

        CardOnTable2 = CardOnBoardText1;

        
        foreach (char v in currency11.game.board[2])
        {
            CardOnBoardSuit2 = Convert.ToString(v);

        }
        foreach (char v in currency11.game.board[2])
        {
            CardOnBoardText2 = Convert.ToString(v);
            break;
        }

        CardOnTable3 = CardOnBoardText2;
        
        foreach (char v in currency11.game.board[3])
        {
            CardOnBoardSuit3 = Convert.ToString(v);

        }
        foreach (char v in currency11.game.board[3])
        {
            CardOnBoardText3 = Convert.ToString(v);
            break;
        }

        CardOnTable4 = CardOnBoardText3;

        
        foreach (char v in currency11.game.board[4])
        {
            CardOnBoardSuit4 = Convert.ToString(v);

        }
        foreach (char v in currency11.game.board[4])
        {
            CardOnBoardText4 = Convert.ToString(v);
            break;
        }
        CardOnTable5 = CardOnBoardText4;
        /*var currency111 = JsonConvert.DeserializeObject<RootAction>(responce1111); 

        
        if (currency111.game.state == "COMPLETED")
        {

            int? ioi = currency111.winners[0].userId;
            Debug.Log(ioi);
            WinsMessage = Convert.ToString(ioi);
            Debug.Log(WinsMessage);



        }
        */

        /*CardOnTable1 = currency11.game.board[0];*/
        /* CardOnTable2 = currency11.game.board[1];*/
        /*CardOnTable3 = currency11.game.board[2];*/
        /*CardOnTable4 = currency11.game.board[3];*/
        /*CardOnTable5 = currency11.game.board[4];*/




    }
    // Start is called before the first frame update
    public async void JoinTablePoker()
    {
        Glob.tm = new TimerCallback(Reset);
        // создаем таймер
        Glob.timer = new Timer(Glob.tm, Glob.num, 0, 1000);

        WebSocket ws = new WebSocket(Glob.websocketurl);

        ws.OnMessage += Ws_OnMessage;

        ws.Connect();

        var jsona = new JoinTableAssetsMain
        {
            eventType = "join_table",
            pokerTable = new JoinTableAssetsMain { id = 1 }
        };

        string message = JsonConvert.SerializeObject(jsona);

        ws.Send(message);



        SceneManager.LoadScene(2);

        

    }
    public void Reset(object obj)
    {

        WebSocket ws = new WebSocket(Glob.websocketurl);

        ws.OnMessage += Ws_OnMessage;

        ws.Connect();
        var currency111 = JsonConvert.DeserializeObject<RootAction>(responce11);


        if (currency111.game.state == "COMPLETED")
        {

            string? ioi = currency111.msg;
            Debug.Log(ioi);
            JoinTable.WinsMessage = Convert.ToString(ioi);




        }


        if (currency111.game.board == null)
        {




            CardOnBoardSuit = "Exception";
            CardOnBoardSuit1 = "Exception";
            CardOnBoardSuit2 = "Exception";
            CardOnBoardSuit3 = "Exception";
            CardOnBoardSuit4 = "Exception";
        }
        /*else (currency111.game.state != "COMPLETED"){

       

        }*/
        var currency = JsonConvert.DeserializeObject<Root1>(responce11);
        int l = 0;
        while (l < 4)
                {
            if (currency.seats[l].userId == null || IdOther == l)
            {



                AvaibleTableOther = 0;

                l++;

            }           
            else
            {


                AvaibleTableOther = 1;
                break;
            }
        }


        /* var currency = JsonConvert.DeserializeObject<Root>(responce);
         Debug.Log(currency.seats[0].userChips);
         Debug.Log("123123");*/
    }

}
public class JoinTableAssets
{

    public new JoinTableAssetsMain pokerTable { get; set; }
   
}
public class JoinTableAssetsMain : JoinTableAssets
{
    public string eventType { get; set; }

    public int id { get; set; }

   /* [Newtonsoft.Json.JsonProperty("Msg")]
    public string msg { get; set; }*/

   



    /*[Newtonsoft.Json.JsonProperty("Userchips")]
    public int userChips { get; set; }*/
}
public class Root1 : Seat1
{

   
    public List<Seat1> seats { get; set; }
}


public class Seat1 
{

    public string eventType { get; set; }
    public int? userId { get; set; }
    public int pokerTableId { get; set; }
    public int number { get; set; }
    public List<string> pocket { get; set; }
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

public class Action
{
    public int id { get; set; }
    public int userId { get; set; }
    public int gameId { get; set; }
    public string type { get; set; }
    public int bet { get; set; }
    public string gameState { get; set; }
    public new Game game { get; set; }
}

public class Game : Action
{
    public int id { get; set; }
    public int pokerTableId { get; set; }
    public string state { get; set; }
    public List<string> board { get; set; }
    public int bank { get; set; }
}

public class BestCombination
{
    public List<string> cards { get; set; }
    public string name { get; set; }
}

public class GameAction
{
    public int id { get; set; }
    public int pokerTableId { get; set; }
    public string state { get; set; }
    public List<string> board { get; set; }
    public int bank { get; set; }
}

public class RootAction
{
    public string eventType { get; set; }
    public string msg { get; set; }
    public GameAction game { get; set; }
    public List<Winner> winners { get; set; }
}

public class Winner
{
    public BestCombination bestCombination { get; set; }
    public int userId { get; set; }
    public int chips { get; set; }
}