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

public class EndGameMenuActionScript : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject PrefabGameWinner;
    public Text WinsMessage;
    // Update is called once per frame
   void Start()
    {
        



    }
    
    public async void CloseWinnerMenu()
    {



        JoinTable.EndGameWinner = 0;

        JoinTable.CardOnBoardSuit = "Exception";
        JoinTable.CardOnBoardSuit1 = "Exception";
        JoinTable.CardOnBoardSuit2 = "Exception";
        JoinTable.CardOnBoardSuit3 = "Exception";
        JoinTable.CardOnBoardSuit4 = "Exception";


    }
    
    void Update()
    {
        

        if (JoinTable.EndGameWinner == 1)
        {


            PrefabGameWinner.gameObject.SetActive(true);
            WinsMessage.text = JoinTable.GameWinner;

        }

        else
        {

            PrefabGameWinner.gameObject.SetActive(false);


        }


    }
}
