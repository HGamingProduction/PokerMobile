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

public class RaiseButtonPopUpScript : MonoBehaviour
{
    public Slider MenuRaiseImages;
    public Text TextrLine;
    public static int ValueBet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MenuRaiseImages.minValue = JoinTable.MinRaiseBet;
        MenuRaiseImages.maxValue = Convert.ToInt64(JoinTable.NumberChips);
        /*MenuRaiseImages.minValue = 5;
        MenuRaiseImages.maxValue = 1000;*/

       

        TextrLine.text = MenuRaiseImages.value + "/" + MenuRaiseImages.maxValue;
        ValueBet = Convert.ToInt32(MenuRaiseImages.value);
    }


    public void MultiplyOneHalf()
    {

        MenuRaiseImages.value = Convert.ToInt64(MenuRaiseImages.minValue * 1.5);
        


    }

    public void MultiplyTwo()
    {

        MenuRaiseImages.value = Convert.ToInt64(MenuRaiseImages.minValue * 2);



    }


    public void MultiplyThree()
    {

        MenuRaiseImages.value = Convert.ToInt64(MenuRaiseImages.minValue * 3);



    }

    public void MultiplyAllIn()
    {

        MenuRaiseImages.value = Convert.ToInt64(JoinTable.NumberChips);



    }





}



