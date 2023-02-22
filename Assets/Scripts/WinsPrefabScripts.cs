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

public class WinsPrefabScripts : MonoBehaviour
{
    public GameObject Canvas; //Основной Canvas чи куда
    public RectTransform rectTransform;
    public GameObject Player1;
    public GameObject Player2;
    public GameObject Player3;
    public GameObject Player4;
    public GameObject Player5;
    public GameObject Player6;
    public GameObject Player7;
    public GameObject Player8;
    public GameObject Player9;
    public GameObject Player10;
    public static int WinsPeople;
    void Start()
    {
        GameObject _canvas = Canvas;
        rectTransform = _canvas.GetComponent<RectTransform>();

        if (WinsPeople > 4)
        {
            int ii = WinsPeople - 4;
            rectTransform.sizeDelta = new Vector2(rectTransform.sizeDelta.x + (120 * ii), rectTransform.sizeDelta.y);
        }

        switch (WinsPeople)
        {
            case 1:
                Player1.SetActive(true);
                break;
            case 2:
                Player1.SetActive(true);
                Player2.SetActive(true);
                break;
            case 3:
                Player1.SetActive(true);
                Player2.SetActive(true);
                Player3.SetActive(true);
                break;
            case 4:
                Player1.SetActive(true);
                Player2.SetActive(true);
                Player3.SetActive(true);
                Player4.SetActive(true);
                break;
            case 5:
                Player1.SetActive(true);
                Player2.SetActive(true);
                Player3.SetActive(true);
                Player4.SetActive(true);
                Player5.SetActive(true);
                break;
            case 6:
                Player1.SetActive(true);
                Player2.SetActive(true);
                Player3.SetActive(true);
                Player4.SetActive(true);
                Player5.SetActive(true);
                Player6.SetActive(true);
                break;
            case 7:
                Player1.SetActive(true);
                Player2.SetActive(true);
                Player3.SetActive(true);
                Player4.SetActive(true);
                Player5.SetActive(true);
                Player6.SetActive(true);
                Player7.SetActive(true);
                break;
            case 8:
                Player1.SetActive(true);
                Player2.SetActive(true);
                Player3.SetActive(true);
                Player4.SetActive(true);
                Player5.SetActive(true);
                Player6.SetActive(true);
                Player7.SetActive(true);
                Player8.SetActive(true);
                break;
            case 9:
                Player1.SetActive(true);
                Player2.SetActive(true);
                Player3.SetActive(true);
                Player4.SetActive(true);
                Player5.SetActive(true);
                Player6.SetActive(true);
                Player7.SetActive(true);
                Player8.SetActive(true);
                Player9.SetActive(true);
                break;
            case 10:
                Player1.SetActive(true);
                Player2.SetActive(true);
                Player3.SetActive(true);
                Player4.SetActive(true);
                Player5.SetActive(true);
                Player6.SetActive(true);
                Player7.SetActive(true);
                Player8.SetActive(true);
                Player9.SetActive(true);
                Player10.SetActive(true);
                break;

        }

    }
}
