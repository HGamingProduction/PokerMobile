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

public class ImageViewScript : MonoBehaviour
{

    
    public Image imagecard;
    public Image imagecardClon;
    public Sprite CardsClubs;
    public Sprite CardsDiamond;
    public Sprite CardsHearts;
    public Sprite CardsSpades;
    public Text textcard;
    public Text textcardClon;

    void Start() {
        /*imagecard.gameObject.SetActive(false);
        imagecardClon.gameObject.SetActive(false);*/
        /*imagecard.sprite = maleIcon;*/

    }

    void Update()
    {
        /*imagecard.sprite = maleIcon;*/
 

        switch (JoinTable.Suit)
        {
            case "c":
                imagecard.sprite = CardsClubs;
                imagecard.gameObject.SetActive(true);
                textcard.gameObject.SetActive(true);
                break;
            case "d":
                imagecard.sprite = CardsDiamond;
                imagecard.gameObject.SetActive(true);
                textcard.gameObject.SetActive(true);
                break;
            case "h":
                imagecard.sprite = CardsHearts;
                imagecard.gameObject.SetActive(true);
                textcard.gameObject.SetActive(true);
                break;
            case "s":
                imagecard.sprite = CardsSpades;
                imagecard.gameObject.SetActive(true);
                textcard.gameObject.SetActive(true);
                break;
            default:
                imagecard.gameObject.SetActive(false);
                textcard.gameObject.SetActive(false);
                break;
        }

        switch (JoinTable.SuitClon)
        {
            case "c":
                imagecardClon.sprite = CardsClubs;
                imagecardClon.gameObject.SetActive(true);
                textcardClon.gameObject.SetActive(true);
                break;
            case "d":
                imagecardClon.sprite = CardsDiamond;
                imagecardClon.gameObject.SetActive(true);
                textcardClon.gameObject.SetActive(true);
                break;
            case "h":
                imagecardClon.sprite = CardsHearts;
                imagecardClon.gameObject.SetActive(true);
                textcardClon.gameObject.SetActive(true);
                break;
            case "s":
                imagecardClon.sprite = CardsSpades;
                imagecardClon.gameObject.SetActive(true);
                textcardClon.gameObject.SetActive(true);
                break;
            default:
                imagecardClon.gameObject.SetActive(false);
                textcardClon.gameObject.SetActive(false);
                break;
        }

    }

}