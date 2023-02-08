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

public class RestConnection : MonoBehaviour
{
    
    // Start is called before the first frame update
    public void Start()
    {
       

        
        // устанавливаем метод обратного вызова
      /*  Glob.tm = new TimerCallback(Reset);
        // создаем таймер
        Glob.timer = new Timer(Glob.tm, Glob.num, 0, 5000);*/

    }


   

    public void DeleteTaimer() {
        Glob.timer.Change(Timeout.Infinite, Timeout.Infinite);
        Debug.Log("Connection lost");
    }
    // Update is called once per frame
   
}
