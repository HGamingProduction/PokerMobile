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


public class UpdateGameButtonScript : MonoBehaviour
{
    public Button ButtonFolds;
    public Button ButtonCalls;
    public Button ButtonChecks;
    public Button ButtonRaises;

    public static string?[] availableYourActions = new string?[3];

    void Start()
    {



      
    }

    void Update()
    {
        for (int i = 0; i < 3; i++)
        {



            switch (availableYourActions[i])
            {
                case "CALL":
                    Glob.buttonCallBool = true;
                    break;
                case "RAISE":
                    Glob.buttonRaiseBool = true;
                    break;
                case "FOLD":
                    Glob.buttonFoldBool = true;
                    break;
                case "CHECK":
                    Glob.buttonCheckBool = true;
                    break;

            }
        }
        if (Glob.buttonFoldBool == true)
        {
            ButtonFolds.interactable = true;
        }
        else
        {
            ButtonFolds.interactable = false;
        }
        if (Glob.buttonCallBool == true)
        {
            ButtonCalls.interactable = true;
        }
        else
        {
            ButtonCalls.interactable = false;
        }
        if (Glob.buttonCheckBool == true)
        {
            ButtonChecks.interactable = true;
        }
        else
        {
            ButtonChecks.interactable = false;
        }
        if (Glob.buttonRaiseBool == true)
        {
            ButtonRaises.interactable = true;
        }
        else
        {
            ButtonRaises.interactable = false;
        }





    }
}
