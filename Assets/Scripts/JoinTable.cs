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
    public static string FirstCard;
    public static string SecondCard;
    public static string ThirdCard;
    public static string FourthCard;
    public static string FifthCard;
    public static string PocketFirstCard;
    public static string PocketSecondCard;
    public static int? NumberChips;
    public static int? NumberChipsTwo;
    public static int? NumberChipsTwo2;
    public static int? NumberChipsTwo3;
    public static int? NumberChipsTwo4;
    public static int? NumberChipsTwo5;
    public static int? NumberChipsTwo6;
    public static int? NumberChipsTwo7;
    public static int? NumberChipsTwo8;
    public static int? NumberChipsTwo9;
    public static int? CurrentBet;
    public static int? CurrentBetTwo;
    public static int? CurrentBetTwo2;
    public static int? CurrentBetTwo3;
    public static int? CurrentBetTwo4;
    public static int? CurrentBetTwo5;
    public static int? CurrentBetTwo6;
    public static int? CurrentBetTwo7;
    public static int? CurrentBetTwo8;
    public static int? CurrentBetTwo9;
    public static string MyPocket;
    public static string MyPocket2;
    public static string responce11;
    public static string responce22;
    public static string responce111;
    public static string responce1111;
    public static string CardOnTable1;
    public static string CardOnTable2;
    public static string CardOnTable3;
    public static string CardOnTable4;
    public static string CardOnTable5;
    public static string OtherName9;
    public static string OtherName8;
    public static string OtherName7;
    public static string OtherName6;
    public static string OtherName5;
    public static string OtherName4;
    public static string OtherName3;
    public static string OtherName2;
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
    public static string ActionTypeOther2;
    public static string ActionTypeOther3;
    public static string ActionTypeOther4;
    public static string ActionTypeOther5;
    public static string ActionTypeOther6;
    public static string ActionTypeOther7;
    public static string ActionTypeOther8;
    public static string ActionTypeOther9;
    public static string WinsMessage;
    public static int IdOther;
    public static int AvaibleTableOther;
    public static int AvaibleTableOther2;
    public static int AvaibleTableOther3;
    public static int AvaibleTableOther4;
    public static int AvaibleTableOther5;
    public static int AvaibleTableOther6;
    public static int AvaibleTableOther7;
    public static int AvaibleTableOther8;
    public static int AvaibleTableOther9;
    public static int MyGlobalAvaibleActions;
    public static int FirstGlobalAvaibleActions;
    public static int FirstGlobalAvaibleActions2;
    public static int FirstGlobalAvaibleActions3;
    public static int FirstGlobalAvaibleActions4;
    public static int FirstGlobalAvaibleActions5;
    public static int FirstGlobalAvaibleActions6;
    public static int FirstGlobalAvaibleActions7;
    public static int FirstGlobalAvaibleActions8;
    public static int FirstGlobalAvaibleActions9;
    public static int IdOtherGamer;
    public static int IdOtherGamer2;
    public static int IdOtherGamer3;
    public static int IdOtherGamer4;
    public static int IdOtherGamer5;
    public static int IdOtherGamer6;
    public static int IdOtherGamer7;
    public static int IdOtherGamer8;
    public static int IdOtherGamer9;
    public static string? GameWinner;
    public static int MinRaiseBet;
    public static int EndGameWinner;
    public static string IdText;
    public static string TextArr;
    public static string GlobalCardAction;
    public static string GlobalCardAction2;
    public static string GlobalCardAction3;
    public static string GlobalCardAction4;
    public static int CountPlayers;

    /*public static string responce;*/
    private static void Ws_OnMessage(object sender, MessageEventArgs e)
    {
        Debug.Log("Open:11111 " + e.Data);
        responce22 = e.Data;
        responce11 = e.Data;
        responce111 = e.Data;
        responce1111 = e.Data;
        /*responce = e.Data;*/
        var currency11 = JsonConvert.DeserializeObject<Action>(responce111);
        var currencyWinner = JsonConvert.DeserializeObject<Winner>(responce22);
        var currency = JsonConvert.DeserializeObject<Root1>(responce11);
        var currencyy = JsonConvert.DeserializeObject<Action>(responce11);
        var currencyyy = JsonConvert.DeserializeObject<Root19>(responce1111);

        var currency20 = JsonConvert.DeserializeObject<Game20>(responce1111);



        if (currency.msg == "")
        {
            GlobalCardAction = "FirstException";
            GlobalCardAction2 = "SecondException2";
            GlobalCardAction3 = "SecondException2";
            GlobalCardAction4 = "SecondException2";


            Debug.Log("��������� ������@@@@@@");


            /* if (currencyWinner.bestCombination.cards[0] == FirstCard || currencyWinner.bestCombination.cards[0] == SecondCard || currencyWinner.bestCombination.cards[0] == ThirdCard || currencyWinner.bestCombination.cards[0] == FourthCard || currencyWinner.bestCombination.cards[0] == FifthCard)
             {

                 Debug.Log("����������?????? �� �����");


             }*/
          

            if (currencyWinner.bestCombination.cards[0] == PocketFirstCard)
            {
                GlobalCardAction = "MyCardActionOne";
            }
            
             if (currencyWinner.bestCombination.cards[0] == PocketSecondCard)
            {
                GlobalCardAction = "MyCardActionOneClone";
            }
            
           if (currencyWinner.bestCombination.cards[0] == FirstCard)
            {
                GlobalCardAction = "CardActionOne";
            }
            
            if (currencyWinner.bestCombination.cards[0] == SecondCard)
            {
                GlobalCardAction = "CardActionTwo";
            }
            
            if (currencyWinner.bestCombination.cards[0] == ThirdCard)
            {
                GlobalCardAction = "CardActionThree";
            }
            
            if (currencyWinner.bestCombination.cards[0] == FourthCard)
            {
                GlobalCardAction = "CardActionFour";
            }
            
            if (currencyWinner.bestCombination.cards[0] == FifthCard)
            {
                GlobalCardAction = "CardActionFive";
            }
           




            if (currencyWinner.bestCombination.cards[1] == PocketFirstCard)
            {
                GlobalCardAction2 = "MyCardActionOne2";
            }
           
             if (currencyWinner.bestCombination.cards[1] == PocketSecondCard)
            {
                GlobalCardAction2 = "MyCardActionOne2Clone";
            }
           
            if (currencyWinner.bestCombination.cards[1] == FirstCard)
            {
                GlobalCardAction2 = "CardActionOne2";
            }
           
            if (currencyWinner.bestCombination.cards[1] == SecondCard)
            {
                GlobalCardAction2 = "CardActionTwo2";
            }
            
            if (currencyWinner.bestCombination.cards[1] == ThirdCard)
            {
                GlobalCardAction2 = "CardActionThree2";
            }
            
            if (currencyWinner.bestCombination.cards[1] == FourthCard)
            {
                GlobalCardAction2 = "CardActionFour2";
            }
           
            if (currencyWinner.bestCombination.cards[1] == FifthCard)
            {
                GlobalCardAction2 = "CardActionFive2";
            }





            if (currencyWinner.bestCombination.cards[2] == PocketFirstCard)
            {
                GlobalCardAction3 = "MyCardActionOne3";
            }
          
            if (currencyWinner.bestCombination.cards[2] == PocketSecondCard)
            {
                GlobalCardAction3 = "MyCardActionOneClone3";
            }
            
          if (currencyWinner.bestCombination.cards[2] == FirstCard)
            {
                GlobalCardAction3 = "CardActionOne3";
            }
          
           if (currencyWinner.bestCombination.cards[2] == SecondCard)
            {
                GlobalCardAction3 = "CardActionTwo3";
            }
            
           if (currencyWinner.bestCombination.cards[2] == ThirdCard)
            {
                GlobalCardAction3 = "CardActionThree3";
            }
            
           if (currencyWinner.bestCombination.cards[2] == FourthCard)
            {
                GlobalCardAction3 = "CardActionFour3";
            }
            
           if (currencyWinner.bestCombination.cards[2] == FifthCard)
            {
                GlobalCardAction3 = "CardActionFive3";
            }



            if (currencyWinner.bestCombination.cards[3] == PocketFirstCard)
            {
                GlobalCardAction4 = "MyCardActionOne4";
            }
           
            if (currencyWinner.bestCombination.cards[3] == PocketSecondCard)
            {
                GlobalCardAction4 = "MyCardActionOneClone4";
            }
           
          if (currencyWinner.bestCombination.cards[3] == FirstCard)
            {
                GlobalCardAction4 = "CardActionOne4";
            }
            
           if (currencyWinner.bestCombination.cards[3] == SecondCard)
            {
                GlobalCardAction4 = "CardActionTwo4";
            }

            if (currencyWinner.bestCombination.cards[3] == ThirdCard)
            {
                GlobalCardAction4 = "CardActionThree4";
            }
           
            if (currencyWinner.bestCombination.cards[3] == FourthCard)
            {
                GlobalCardAction4 = "CardActionFour4";
            }
           
            if (currencyWinner.bestCombination.cards[3] == FifthCard)
            {
                GlobalCardAction4 = "CardActionFive4";
            }
            /*else if (currencyWinner.bestCombination.cards[1] != FirstCard && currencyWinner.bestCombination.cards[1] != SecondCard && currencyWinner.bestCombination.cards[1] != ThirdCard && currencyWinner.bestCombination.cards[1] != FourthCard && currencyWinner.bestCombination.cards[1] != FifthCard && currencyWinner.bestCombination.cards[1] != PocketFirstCard && currencyWinner.bestCombination.cards[1] != PocketSecondCard)
            {

                GlobalCardAction2 = "SecondException2";

            }*/














        }



        if (currency.eventType == "action")
        {
            MinRaiseBet = currency.seats[IdOther].raiseMinBet;
            NumberChips = currency.seats[IdOther].userChips;
            CurrentBet = currency.seats[IdOther].current_bet;
            MyName = currency.seats[IdOther].userName;


         

            MinRaiseBet = currency.seats[IdOther].raiseMinBet;

          

            if (currency20.state == "COMPLETED")
            {

                Debug.Log("123123123123123");


            }
            else { Debug.Log(currency20.state); }

        }
        if (currency.msg == "new game at the table #"+ IdText +" started")
        {
            
            BankOnTable = currencyy.game.bank;
            NumberChips = currency.seats[IdOther].userChips;
            CurrentBet = currency.seats[IdOther].current_bet;
            MyName = currency.seats[IdOther].userName;

            NumberChipsTwo = currency.seats[IdOtherGamer].userChips;
            CurrentBetTwo = currency.seats[IdOtherGamer].current_bet;
            OtherName = currency.seats[IdOtherGamer].userName;
            NumberChipsTwo2 = currency.seats[IdOtherGamer2].userChips;
            CurrentBetTwo2 = currency.seats[IdOtherGamer2].current_bet;
            OtherName2 = currency.seats[IdOtherGamer2].userName;
            NumberChipsTwo3 = currency.seats[IdOtherGamer3].userChips;
            CurrentBetTwo3 = currency.seats[IdOtherGamer3].current_bet;
            OtherName3 = currency.seats[IdOtherGamer3].userName;
            if (currency.seats[IdOther].availableActions == null)
            {

                MyGlobalAvaibleActions = 0;

            }
            if (currency.seats[IdOther].availableActions != null)
            {


                MyGlobalAvaibleActions = 1;



            }

            if (currency.seats[IdOtherGamer].availableActions == null)
            {

                FirstGlobalAvaibleActions = 0;

            }
            if (currency.seats[IdOtherGamer].availableActions != null)
            {


                FirstGlobalAvaibleActions = 1;



            }

            if (currency.seats[IdOtherGamer2].availableActions == null)
            {

                FirstGlobalAvaibleActions2 = 0;

            }
            if (currency.seats[IdOtherGamer2].availableActions != null)
            {


                FirstGlobalAvaibleActions2 = 1;



            }


            if (currency.seats[IdOtherGamer3].availableActions == null)
            {

                FirstGlobalAvaibleActions3 = 0;

            }
            if (currency.seats[IdOtherGamer3].availableActions != null)
            {


                FirstGlobalAvaibleActions3 = 1;



            }
            if (currency.seats[IdOtherGamer4].availableActions == null)
            {

                FirstGlobalAvaibleActions4 = 0;

            }
            if (currency.seats[IdOtherGamer4].availableActions != null)
            {


                FirstGlobalAvaibleActions4 = 1;



            }
            if (currency.seats[IdOtherGamer5].availableActions == null)
            {

                FirstGlobalAvaibleActions5 = 0;

            }
            if (currency.seats[IdOtherGamer5].availableActions != null)
            {


                FirstGlobalAvaibleActions5 = 1;



            }

            if (currency.seats[IdOtherGamer6].availableActions == null)
            {

                FirstGlobalAvaibleActions6 = 0;

            }
            if (currency.seats[IdOtherGamer6].availableActions != null)
            {


                FirstGlobalAvaibleActions6 = 1;



            }

            if (currency.seats[IdOtherGamer7].availableActions == null)
            {

                FirstGlobalAvaibleActions7 = 0;

            }
            if (currency.seats[IdOtherGamer7].availableActions != null)
            {


                FirstGlobalAvaibleActions7 = 1;



            }


            if (currency.seats[IdOtherGamer8].availableActions == null)
            {

                FirstGlobalAvaibleActions8 = 0;

            }
            if (currency.seats[IdOtherGamer8].availableActions != null)
            {


                FirstGlobalAvaibleActions8 = 1;



            }


            if (currency.seats[IdOtherGamer9].availableActions == null)
            {

                FirstGlobalAvaibleActions9 = 0;

            }
            if (currency.seats[IdOtherGamer9].availableActions != null)
            {


                FirstGlobalAvaibleActions9 = 1;



            }

            Debug.Log("��������� ������");
        }




        if (currencyy.eventType == "start_game")
        {

            GlobalCardAction = "FirstException";
            GlobalCardAction2 = "SecondException2";
            GlobalCardAction3 = "SecondException2";
            GlobalCardAction4 = "SecondException2";


            Debug.Log("��������� VTOROI START");



            if (currencyy.pocket[0] == null)
            {

                Debug.Log("��������� ����� ����  " + currencyy.pocket[0]);
                Suit = "Exception";
                SuitClon = "Exception";
            }
            else

       if (currencyy.pocket[0] != null)
            {
                foreach (char v in currencyy.pocket[0])
                {
                    
                    Debug.Log("��������� ����� ����  " + currencyy.pocket[0]);
                    Suit = Convert.ToString(v);

                }
                foreach (char v in currencyy.pocket[0])
                {
                    NumberCard = Convert.ToString(v);
                    break;
                }

            }
            if (NumberCard == "T")
            {

                NumberCard = "10";
                MyPocket = NumberCard;

            }
            else
            {
                MyPocket = NumberCard;
            }

            PocketFirstCard = currencyy.pocket[0];
            if (currencyy.pocket[1] != null)
            {
                foreach (char v in currencyy.pocket[1])
                {
                    SuitClon = Convert.ToString(v);

                }
                foreach (char v in currencyy.pocket[1])
                {
                    NumberCardClon = Convert.ToString(v);
                    break;
                }

            }
            if (NumberCardClon == "T")
            {

                NumberCardClon = "10";
                MyPocket2 = NumberCardClon;
            }
            else
            {
                MyPocket2 = NumberCardClon;
            }
            
            PocketSecondCard = currencyy.pocket[1];

            Debug.Log("��������� ����� ����  " + currencyy.pocket[0]);
            MinRaiseBet = currency.seats[IdOther].raiseMinBet;
            VisiblePlayer();

           

        }

        if (currency.eventType == "join_table")
        {

            MinRaiseBet = currency.seats[IdOther].raiseMinBet;
            NumberChips = currency.seats[IdOther].userChips;
            CurrentBet = currency.seats[IdOther].current_bet;
            MyName = currency.seats[IdOther].userName;
            VisiblePlayer();

           


        }
        if (currency.eventType == "leave_table")
        {
            VisiblePlayer();

          


        }
        if (currency.eventType == "end_game")
        {


            GameWinner = currency.msg;

            /*JoinTable.WinsMessage = Convert.ToString(GameWinner);*/

            EndGameWinner = 1;

            GlobalCardAction = "FirstException";
            GlobalCardAction2 = "SecondException2";
            GlobalCardAction3 = "SecondException2";
            GlobalCardAction4 = "SecondException2";

          
            Debug.Log("��������� ��� ����");

        }

       /* GlobalCardAction = "FirstException";
        GlobalCardAction2 = "SecondException2";
        GlobalCardAction3 = "SecondException2";
        GlobalCardAction4 = "SecondException2";*/
        int a = 0;
        int i = 0;
        int b = 0;
        int? g = 0;
        int o = 0;
        int aa = 0;
        int? gg = 0;
        int aaa = 0;
        int? ggg = 0;
        int aaa4 = 0;
        int? ggg4 = 0;
        int aaa5 = 0;
        int? ggg5 = 0;
        int aaa6 = 0;
        int? ggg6 = 0;      
        int aaa7 = 0;
        int? ggg7 = 0;
        int aaa8 = 0;
        int? ggg8 = 0;
        int aaa9 = 0;
        int? ggg9 = 0;


        while (i < CountPlayers)
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
        MinRaiseBet = currency.seats[IdOther].raiseMinBet;
        NumberChips = currency.seats[IdOther].userChips;
        CurrentBet = currency.seats[IdOther].current_bet;
        MyName = currency.seats[IdOther].userName;
        if (currency.seats[i].lastActionType == null)
        {

            ActionTypeMy = "NUll";

        }
        else
        {
            ActionTypeMy = Convert.ToString(currency.seats[i].lastActionType);
        }
        Debug.Log(currency.seats[i].lastActionType);
       
        while (a < CountPlayers)
        {
            
            if (currency.seats[a].userId != Glob.GlobalId)
            {


                Debug.Log("DANYALOSHARAazaaaaa");
                break;

            }
            else
            {

                a++;
            }

        }
        IdOtherGamer = a;
        g = currency.seats[a].userId;



        while (aa < CountPlayers)
        {

            Debug.Log("DANYALOSHARA111222");
            if (currency.seats[aa].userId != Glob.GlobalId && currency.seats[aa].userId != currency.seats[a].userId && currency.seats[aa].userId != null)
            {



                break;

            }
            else
            {

                aa++;
            }

        }
        IdOtherGamer2 = aa;
        gg = currency.seats[aa].userId;



        while (aaa < CountPlayers)
        {
            if (currency.seats[aaa].userId != Glob.GlobalId && currency.seats[aaa].userId != currency.seats[aa].userId && currency.seats[aaa].userId != currency.seats[a].userId && currency.seats[aaa].userId != null)
            {



                break;

            }
            else
            {

                aaa++;
            }

        }
        IdOtherGamer3 = aaa;
        ggg = currency.seats[aaa].userId;


        while (aaa4 < CountPlayers)
        {
            if (currency.seats[aaa4].userId != Glob.GlobalId && currency.seats[aaa4].userId != currency.seats[aaa].userId && currency.seats[aaa4].userId != currency.seats[aa].userId && currency.seats[aaa4].userId != currency.seats[a].userId && currency.seats[aaa4].userId != null)
            {



                break;

            }
            else
            {

                aaa4++;
            }

        }
        IdOtherGamer4 = aaa4;
        ggg4 = currency.seats[aaa4].userId;

        while (aaa5 < CountPlayers)
        {
            if (currency.seats[aaa5].userId != Glob.GlobalId && currency.seats[aaa5].userId != currency.seats[aaa4].userId && currency.seats[aaa5].userId != currency.seats[aaa].userId && currency.seats[aaa5].userId != currency.seats[aa].userId && currency.seats[aaa5].userId != currency.seats[a].userId && currency.seats[aaa5].userId != null)
            {



                break;

            }
            else
            {

                aaa5++;
            }

        }
        IdOtherGamer5 = aaa5;
        ggg5 = currency.seats[aaa5].userId;

        while (aaa6 < CountPlayers)
        {
            if (currency.seats[aaa6].userId != Glob.GlobalId && currency.seats[aaa6].userId != currency.seats[aaa5].userId && currency.seats[aaa6].userId != currency.seats[aaa4].userId && currency.seats[aaa6].userId != currency.seats[aaa].userId && currency.seats[aaa6].userId != currency.seats[aa].userId && currency.seats[aaa6].userId != currency.seats[a].userId && currency.seats[aaa6].userId != null)
            {



                break;

            }
            else
            {

                aaa6++;
            }

        }
        IdOtherGamer6 = aaa6;
        ggg6 = currency.seats[aaa6].userId;

        while (aaa7 < CountPlayers)
        {
            if (currency.seats[aaa7].userId != Glob.GlobalId && currency.seats[aaa7].userId != currency.seats[aaa6].userId && currency.seats[aaa7].userId != currency.seats[aaa5].userId && currency.seats[aaa7].userId != currency.seats[aaa4].userId && currency.seats[aaa7].userId != currency.seats[aaa].userId && currency.seats[aaa7].userId != currency.seats[aa].userId && currency.seats[aaa7].userId != currency.seats[a].userId && currency.seats[aaa7].userId != null)
            {



                break;

            }
            else
            {

                aaa7++;
            }

        }
        IdOtherGamer7 = aaa7;
        ggg7 = currency.seats[aaa7].userId;

        while (aaa8 < CountPlayers)
        {
            if (currency.seats[aaa8].userId != Glob.GlobalId && currency.seats[aaa8].userId != currency.seats[aaa7].userId && currency.seats[aaa8].userId != currency.seats[aaa6].userId && currency.seats[aaa8].userId != currency.seats[aaa5].userId && currency.seats[aaa8].userId != currency.seats[aaa4].userId && currency.seats[aaa8].userId != currency.seats[aaa].userId && currency.seats[aaa8].userId != currency.seats[aa].userId && currency.seats[aaa8].userId != currency.seats[a].userId && currency.seats[aaa8].userId != null)
            {



                break;

            }
            else
            {

                aaa8++;
            }

        }
        IdOtherGamer8 = aaa8;
        ggg8 = currency.seats[aaa8].userId;

        while (aaa9 < CountPlayers)
        {
            if (currency.seats[aaa9].userId != Glob.GlobalId && currency.seats[aaa9].userId != currency.seats[aaa8].userId && currency.seats[aaa9].userId != currency.seats[aaa7].userId && currency.seats[aaa9].userId != currency.seats[aaa6].userId && currency.seats[aaa9].userId != currency.seats[aaa5].userId && currency.seats[aaa9].userId != currency.seats[aaa4].userId && currency.seats[aaa9].userId != currency.seats[aaa].userId && currency.seats[aaa9].userId != currency.seats[aa].userId && currency.seats[aaa9].userId != currency.seats[a].userId && currency.seats[aaa9].userId != null)
            {



                break;

            }
            else
            {

                aaa9++;
            }

        }
        IdOtherGamer9 = aaa9;
        ggg9 = currency.seats[aaa9].userId;







        if (currency.seats[i].availableActions == null)
        {

            MyGlobalAvaibleActions = 0;

        }
        if (currency.seats[i].availableActions != null)
        {


            MyGlobalAvaibleActions = 1;
            int p = 0;
            if (currency.seats[IdOther].availableActions[p] != null)
            {

                for (p = 0; p < 3; p++)
                {
                  

                    UpdateGameButtonScript.availableYourActions[p] = currency.seats[IdOther].availableActions[p];




                }
            }


        }

        if (currency.seats[a].availableActions == null)
        {

            FirstGlobalAvaibleActions = 0;

        }
        if (currency.seats[a].availableActions != null)
        {


            FirstGlobalAvaibleActions = 1;



        }


        if (currency.seats[aa].availableActions == null)
        {

            FirstGlobalAvaibleActions2 = 0;

        }
        if (currency.seats[aa].availableActions != null)
        {


            FirstGlobalAvaibleActions2 = 1;



        }



        if (currency.seats[aaa].availableActions == null)
        {

            FirstGlobalAvaibleActions3 = 0;

        }
        if (currency.seats[aaa].availableActions != null)
        {


            FirstGlobalAvaibleActions3 = 1;



        }
        if (currency.seats[aaa4].availableActions == null)
        {

            FirstGlobalAvaibleActions4 = 0;

        }
        if (currency.seats[aaa4].availableActions != null)
        {


            FirstGlobalAvaibleActions4 = 1;



        }

        if (currency.seats[aaa5].availableActions == null)
        {

            FirstGlobalAvaibleActions5 = 0;

        }
        if (currency.seats[aaa5].availableActions != null)
        {


            FirstGlobalAvaibleActions5 = 1;



        }

        if (currency.seats[aaa6].availableActions == null)
        {

            FirstGlobalAvaibleActions6 = 0;

        }
        if (currency.seats[aaa6].availableActions != null)
        {


            FirstGlobalAvaibleActions6 = 1;



        }

        if (currency.seats[aaa7].availableActions == null)
        {

            FirstGlobalAvaibleActions7 = 0;

        }
        if (currency.seats[aaa7].availableActions != null)
        {


            FirstGlobalAvaibleActions7 = 1;



        }


        if (currency.seats[aaa8].availableActions == null)
        {

            FirstGlobalAvaibleActions8 = 0;

        }
        if (currency.seats[aaa8].availableActions != null)
        {


            FirstGlobalAvaibleActions8 = 1;



        }


        if (currency.seats[aaa9].availableActions == null)
        {

            FirstGlobalAvaibleActions9 = 0;

        }
        if (currency.seats[aaa9].availableActions != null)
        {


            FirstGlobalAvaibleActions9 = 1;



        }








        VisiblePlayer();
  
        





        if (currency.seats[a].lastActionType == null)
        {

            ActionTypeOther = "NUll";

        }
        else
        {
            ActionTypeOther = Convert.ToString(currency.seats[a].lastActionType);
        }


        if (currency.seats[aa].lastActionType == null)
        {

            ActionTypeOther2 = "NUll";

        }
        else
        {
            ActionTypeOther2 = Convert.ToString(currency.seats[aa].lastActionType);
        }


        if (currency.seats[aaa].lastActionType == null)
        {

            ActionTypeOther3 = "NUll";

        }
        else
        {
            ActionTypeOther3 = Convert.ToString(currency.seats[aaa].lastActionType);
        }


        if (currency.seats[aaa4].lastActionType == null)
        {

            ActionTypeOther4 = "NUll";

        }
        else
        {
            ActionTypeOther4 = Convert.ToString(currency.seats[aaa4].lastActionType);
        }


        if (currency.seats[aaa5].lastActionType == null)
        {

            ActionTypeOther5 = "NUll";

        }
        else
        {
            ActionTypeOther5 = Convert.ToString(currency.seats[aaa5].lastActionType);
        }


        if (currency.seats[aaa6].lastActionType == null)
        {

            ActionTypeOther6 = "NUll";

        }
        else
        {
            ActionTypeOther6 = Convert.ToString(currency.seats[aaa6].lastActionType);
        }


        if (currency.seats[aaa7].lastActionType == null)
        {

            ActionTypeOther7 = "NUll";

        }
        else
        {
            ActionTypeOther7 = Convert.ToString(currency.seats[aaa7].lastActionType);
        }


        if (currency.seats[aaa8].lastActionType == null)
        {

            ActionTypeOther8 = "NUll";

        }
        else
        {
            ActionTypeOther8 = Convert.ToString(currency.seats[aaa8].lastActionType);
        }


        if (currency.seats[aaa9].lastActionType == null)
        {

            ActionTypeOther9 = "NUll";

        }
        else
        {
            ActionTypeOther9 = Convert.ToString(currency.seats[aaa9].lastActionType);
        }














        if (currency.seats[a] == null)
        {





        }
        if (currency.seats[a].userId == g)
        {
            NumberChipsTwo = currency.seats[a].userChips;
            CurrentBetTwo = currency.seats[a].current_bet;
            OtherName = currency.seats[a].userName;

        }
        if (currency.seats[aa].userId == gg)
        {

            NumberChipsTwo2 = currency.seats[IdOtherGamer2].userChips;
            CurrentBetTwo2 = currency.seats[IdOtherGamer2].current_bet;
            OtherName2 = currency.seats[IdOtherGamer2].userName;
        }
        if (currency.seats[aaa].userId == ggg)
        {

            NumberChipsTwo3 = currency.seats[IdOtherGamer3].userChips;
            CurrentBetTwo3 = currency.seats[IdOtherGamer3].current_bet;
            OtherName3 = currency.seats[IdOtherGamer3].userName;
        }
        if (currency.seats[aaa4].userId == ggg4)
        {

            NumberChipsTwo4 = currency.seats[IdOtherGamer4].userChips;
            CurrentBetTwo4= currency.seats[IdOtherGamer4].current_bet;
            OtherName4 = currency.seats[IdOtherGamer4].userName;
        }
        if (currency.seats[aaa5].userId == ggg5)
        {

            NumberChipsTwo5 = currency.seats[IdOtherGamer5].userChips;
            CurrentBetTwo5 = currency.seats[IdOtherGamer5].current_bet;
            OtherName5 = currency.seats[IdOtherGamer5].userName;
        }
        if (currency.seats[aaa6].userId == ggg6)
        {

            NumberChipsTwo6 = currency.seats[IdOtherGamer6].userChips;
            CurrentBetTwo6 = currency.seats[IdOtherGamer6].current_bet;
            OtherName6 = currency.seats[IdOtherGamer6].userName;
        }
        if (currency.seats[aaa7].userId == ggg7)
        {

            NumberChipsTwo7 = currency.seats[IdOtherGamer7].userChips;
            CurrentBetTwo7 = currency.seats[IdOtherGamer7].current_bet;
            OtherName7 = currency.seats[IdOtherGamer7].userName;
        }
        if (currency.seats[aaa8].userId == ggg8)
        {

            NumberChipsTwo8 = currency.seats[IdOtherGamer8].userChips;
            CurrentBetTwo8 = currency.seats[IdOtherGamer8].current_bet;
            OtherName8 = currency.seats[IdOtherGamer8].userName;
        }
        if (currency.seats[aaa9].userId == ggg9)
        {

            NumberChipsTwo9 = currency.seats[IdOtherGamer9].userChips;
            CurrentBetTwo9 = currency.seats[IdOtherGamer9].current_bet;
            OtherName9 = currency.seats[IdOtherGamer9].userName;
        }



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

        if (CardOnBoardText == "T")
        {
            CardOnBoardText = "10";
            CardOnTable1 = CardOnBoardText; }



        else

        { CardOnTable1 = CardOnBoardText; }

        FirstCard = currency11.game.board[0];
        
        foreach (char v in currency11.game.board[1])
        {
            CardOnBoardSuit1 = Convert.ToString(v);

        }
        foreach (char v in currency11.game.board[1])
        {
            CardOnBoardText1 = Convert.ToString(v);
            break;
        }

        if (CardOnBoardText1 == "T")
        {
            CardOnBoardText1 = "10";
            CardOnTable2 = CardOnBoardText1;
        }



        else

        { CardOnTable2 = CardOnBoardText1; }





           
        SecondCard = currency11.game.board[1];
        
        foreach (char v in currency11.game.board[2])
        {
            CardOnBoardSuit2 = Convert.ToString(v);

        }
        foreach (char v in currency11.game.board[2])
        {
            CardOnBoardText2 = Convert.ToString(v);
            break;
        }

        if (CardOnBoardText2 == "T")
        {
            CardOnBoardText2 = "10";
            CardOnTable3 = CardOnBoardText2;
        }



        else

        { CardOnTable3 = CardOnBoardText2; }



        ThirdCard = currency11.game.board[2];
       
        foreach (char v in currency11.game.board[3])
        {
            CardOnBoardSuit3 = Convert.ToString(v);

        }
        foreach (char v in currency11.game.board[3])
        {
            CardOnBoardText3 = Convert.ToString(v);
            break;
        }

        if (CardOnBoardText3 == "T")
        {
            CardOnBoardText3 = "10";
            CardOnTable4 = CardOnBoardText3;
        }



        else

        { CardOnTable4 = CardOnBoardText3; }


       
        FourthCard = currency11.game.board[3];
       
        foreach (char v in currency11.game.board[4])
        {
            CardOnBoardSuit4 = Convert.ToString(v);

        }
        foreach (char v in currency11.game.board[4])
        {
            CardOnBoardText4 = Convert.ToString(v);
            break;
        }


        if (CardOnBoardText4 == "T")
        {
            CardOnBoardText4 = "10";
            CardOnTable5 = CardOnBoardText4;
        }



        else

        { CardOnTable5 = CardOnBoardText4; }


        FifthCard = currency11.game.board[4];


        var currency111 = JsonConvert.DeserializeObject<RootAction>(responce11);


        /*if (currency111.game.state == "COMPLETED")
        {

            string? ioi = currency111.msg;
            Debug.Log(ioi);
            JoinTable.WinsMessage = Convert.ToString(ioi);




        }*/


        if (currency111.game.board == null)
        {




            CardOnBoardSuit = "Exception";
            CardOnBoardSuit1 = "Exception";
            CardOnBoardSuit2 = "Exception";
            CardOnBoardSuit3 = "Exception";
            CardOnBoardSuit4 = "Exception";
        }
        

    }

    public static void AvaibleActionsOnTable()
    {

      






    }

    public static void VisiblePlayer()
    {
        var currency = JsonConvert.DeserializeObject<Root1>(responce11);

        int setUpId;
        int setUpId2;
        setUpId = FindAllTables.CountSeatsInTable[Convert.ToInt32(TextArr)];
        setUpId = setUpId - 1;
        CountPlayers = setUpId;
        Debug.Log("DOBRYYYVE4iR" + setUpId + "asdasdasdasd");
        setUpId2 = CountPlayers + 1;
        int l = 0;
        while (l < setUpId2)
        {
            if (currency.seats[IdOtherGamer].userId == null || IdOther == l)
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

        int ll = 0;
        while (ll < setUpId2)
        {
            if (currency.seats[ll].userId == null || IdOther == ll || IdOtherGamer == ll)
            {



                AvaibleTableOther2 = 0;

                ll++;

            }
            else
            {


                AvaibleTableOther2 = 1;
                break;
            }
        }


        int lll = 0;
        while (lll < setUpId2)
        {
            if (currency.seats[lll].userId == null || IdOther == lll || IdOtherGamer == lll || IdOtherGamer2 == lll)
            {



                AvaibleTableOther3 = 0;

                lll++;

            }
            else
            {


                AvaibleTableOther3 = 1;
                break;
            }
        }

        int lll4 = 0;
        while (lll4 < setUpId2)
        {
            if (currency.seats[lll4].userId == null || IdOther == lll4 || IdOtherGamer == lll4 || IdOtherGamer2 == lll4 || IdOtherGamer3 == lll4)
            {



                AvaibleTableOther4 = 0;

                lll4++;

            }
            else
            {


                AvaibleTableOther4 = 1;
                break;
            }
        }


        int lll5 = 0;
        while (lll5 < setUpId2)
        {
            if (currency.seats[lll5].userId == null || IdOther == lll5 || IdOtherGamer == lll5 || IdOtherGamer2 == lll5 || IdOtherGamer3 == lll5 || IdOtherGamer4 == lll5)
            {



                AvaibleTableOther5 = 0;

                lll5++;

            }
            else
            {


                AvaibleTableOther5 = 1;
                break;
            }
        }


        int lll6 = 0;
        while (lll6 < setUpId2)
        {
            if (currency.seats[lll6].userId == null || IdOther == lll6 || IdOtherGamer == lll6 || IdOtherGamer2 == lll6 || IdOtherGamer3 == lll6 || IdOtherGamer4 == lll6 || IdOtherGamer5 == lll6)
            {



                AvaibleTableOther6 = 0;

                lll6++;

            }
            else
            {


                AvaibleTableOther6 = 1;
                break;
            }
        }


        int lll7 = 0;
        while (lll7 < setUpId2)
        {
            if (currency.seats[lll7].userId == null || IdOther == lll7 || IdOtherGamer == lll7 || IdOtherGamer2 == lll7 || IdOtherGamer3 == lll7 || IdOtherGamer4 == lll7|| IdOtherGamer5 == lll7|| IdOtherGamer6 == lll7)
            {



                AvaibleTableOther7 = 0;

                lll7++;

            }
            else
            {


                AvaibleTableOther7 = 1;
                break;
            }
        }


        int lll8 = 0;
        while (lll8 < setUpId2)
        {
            if (currency.seats[lll8].userId == null || IdOther == lll8 || IdOtherGamer == lll8 || IdOtherGamer2 == lll8 || IdOtherGamer3 == lll8 || IdOtherGamer4 == lll8 || IdOtherGamer5 == lll8 || IdOtherGamer6 == lll8 || IdOtherGamer7 == lll8)
            {



                AvaibleTableOther8 = 0;

                lll8++;

            }
            else
            {


                AvaibleTableOther8 = 1;
                break;
            }
        }


        int lll9 = 0;
        while (lll9 < setUpId2)
        {
            if (currency.seats[lll9].userId == null || IdOther == lll9 || IdOtherGamer == lll9 || IdOtherGamer2 == lll9 || IdOtherGamer3 == lll9 || IdOtherGamer4 == lll9 || IdOtherGamer5 == lll9 || IdOtherGamer6 == lll9|| IdOtherGamer7 == lll9 || IdOtherGamer8 == lll9)
            {



                AvaibleTableOther9 = 0;

                lll9++;

            }
            else
            {


                AvaibleTableOther9 = 1;
                break;
            }
        }




    }
    // Start is called before the first frame update
    public async void JoinTablePoker()
    {
        int textIdInt = 0;

        MainWebSocket.ws.OnMessage += Ws_OnMessage;
        MainWebSocket.ws.Connect();


        textIdInt = Convert.ToInt32(IdText);

        var jsona = new JoinTableAssetsMain
        {
            eventType = "join_table",
            pokerTable = new JoinTableAssetsMain { id = textIdInt }
        };



        string message = JsonConvert.SerializeObject(jsona);
        MainWebSocket.ws.Send(message);
        Debug.Log(TextArr);
        SceneManager.LoadScene(2);
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

    public string msg { get; set; }
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

public class Root19 : Seat19
{

    public string msg { get; set; }
    public List<Seat19> seats { get; set; }
}


public class Seat19
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
    public string eventType { get; set; }
    public int id { get; set; }
    public int userId { get; set; }
    public int gameId { get; set; }
    public string type { get; set; }
    public int bet { get; set; }
    public string gameState { get; set; }
    public new Game game { get; set; }
    public List<string> pocket { get; set; }
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

public class Winner : BestCombination
{
    public BestCombination bestCombination { get; set; }
    public int userId { get; set; }
    public int chips { get; set; }
}





public class Action20
{
    public int id { get; set; }
    public int userId { get; set; }
    public int gameId { get; set; }
    public string type { get; set; }
    public int bet { get; set; }
    public string gameState { get; set; }
}

public class Game20
{
    public int id { get; set; }
    public int pokerTableId { get; set; }
    public string state { get; set; }
    public List<string> board { get; set; }
    public int bank { get; set; }
}

public class Root20
{
    public string eventType { get; set; }
    public string msg { get; set; }
    public List<Seat> seats { get; set; }
    public Game game { get; set; }
    public Action action { get; set; }
}

public class Seat20
{
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
