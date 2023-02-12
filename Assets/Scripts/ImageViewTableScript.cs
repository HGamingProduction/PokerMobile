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

public class ImageViewTableScript : MonoBehaviour
{
    public Sprite CardsClubs;
    public Sprite CardsDiamond;
    public Sprite CardsHearts;
    public Sprite CardsSpades;
    public Image TableCardImage;
    public Image TableCardImage1;
    public Image TableCardImage2;
    public Image TableCardImage3;
    public Image TableCardImage4;
    public Text TableCardText;
    public Text TableCardText1;
    public Text TableCardText2;
    public Text TableCardText3;
    public Text TableCardText4;
    public GameObject Card;
    public GameObject Card1;
    public GameObject Card2;
    public GameObject Card3;
    public GameObject Card4;
    // Start is called before the first frame update
    void Start()
    {
        /*Card.gameObject.SetActive(false);
        Card1.gameObject.SetActive(false);
        Card2.gameObject.SetActive(false);
        Card3.gameObject.SetActive(false);
        Card4.gameObject.SetActive(false);*/
        TableCardImage.gameObject.SetActive(false);
        TableCardImage1.gameObject.SetActive(false);
        TableCardImage2.gameObject.SetActive(false);
        TableCardImage3.gameObject.SetActive(false);
        TableCardImage4.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        switch (JoinTable.CardOnBoardSuit)
        {
            case "c":
                TableCardImage.sprite = CardsClubs;
                TableCardImage.gameObject.SetActive(true);
                TableCardText.gameObject.SetActive(true);
                Card.gameObject.SetActive(true);
                
                break;
            case "d":
                TableCardImage.sprite = CardsDiamond;
                TableCardImage.gameObject.SetActive(true);
                TableCardText.gameObject.SetActive(true);
                Card.gameObject.SetActive(true);
                
                break;
            case "h":
                TableCardImage.sprite = CardsHearts;
                TableCardImage.gameObject.SetActive(true);
                TableCardText.gameObject.SetActive(true);
                Card.gameObject.SetActive(true);
                
                break;
            case "s":
                TableCardImage.sprite = CardsSpades;
                TableCardImage.gameObject.SetActive(true);
                TableCardText.gameObject.SetActive(true);
                Card.gameObject.SetActive(true);
                
                break;
           default:
                TableCardImage.gameObject.SetActive(false);
                TableCardText.gameObject.SetActive(false);
                Card.gameObject.SetActive(false);

                break;
        }

        switch (JoinTable.CardOnBoardSuit1)
        {
            case "c":
                TableCardImage1.sprite = CardsClubs;
                TableCardImage1.gameObject.SetActive(true);
                TableCardText1.gameObject.SetActive(true);
                Card1.gameObject.SetActive(true);
          
                break;
            case "d":
                TableCardImage1.sprite = CardsDiamond;
                TableCardImage1.gameObject.SetActive(true);
                TableCardText1.gameObject.SetActive(true);
                Card1.gameObject.SetActive(true);
               
                break;
            case "h":
                TableCardImage1.sprite = CardsHearts;
                TableCardImage1.gameObject.SetActive(true);
                TableCardText1.gameObject.SetActive(true);
                Card1.gameObject.SetActive(true);
                
                break;
            case "s":
                TableCardImage1.sprite = CardsSpades;
                TableCardImage1.gameObject.SetActive(true);
                TableCardText1.gameObject.SetActive(true);
                Card1.gameObject.SetActive(true);
               
                break;
            default:
                TableCardImage1.gameObject.SetActive(false);
                TableCardText1.gameObject.SetActive(false);
                Card1.gameObject.SetActive(false);


                break;
        }
        switch (JoinTable.CardOnBoardSuit2)
        {
            case "c":
                TableCardImage2.sprite = CardsClubs;
                TableCardImage2.gameObject.SetActive(true);
                TableCardText2.gameObject.SetActive(true);
                Card2.gameObject.SetActive(true);
              
                break;
            case "d":
                TableCardImage2.sprite = CardsDiamond;
                TableCardImage2.gameObject.SetActive(true);
                TableCardText2.gameObject.SetActive(true);
                Card2.gameObject.SetActive(true);
               
                break;
            case "h":
                TableCardImage2.sprite = CardsHearts;
                TableCardImage2.gameObject.SetActive(true);
                TableCardText2.gameObject.SetActive(true);
                Card2.gameObject.SetActive(true);
               
                break;
            case "s":
                TableCardImage2.sprite = CardsSpades;
                TableCardImage2.gameObject.SetActive(true);
                TableCardText2.gameObject.SetActive(true);
                Card2.gameObject.SetActive(true);
               
                break;
            default:               
                TableCardImage2.gameObject.SetActive(false);
                TableCardText2.gameObject.SetActive(false);

                Card2.gameObject.SetActive(false);

                break;
        }
        switch (JoinTable.CardOnBoardSuit3)
        {
            case "c":
                TableCardImage3.sprite = CardsClubs;
                TableCardImage3.gameObject.SetActive(true);
                TableCardText3.gameObject.SetActive(true);
                Card3.gameObject.SetActive(true);
               
                break;
            case "d":
                TableCardImage3.sprite = CardsDiamond;
                TableCardImage3.gameObject.SetActive(true);
                TableCardText3.gameObject.SetActive(true);
                Card3.gameObject.SetActive(true);
           
                break;
            case "h":
                TableCardImage3.sprite = CardsHearts;
                TableCardImage3.gameObject.SetActive(true);
                TableCardText3.gameObject.SetActive(true);
                Card3.gameObject.SetActive(true);
                
                break;
            case "s":
                TableCardImage3.sprite = CardsSpades;
                TableCardImage3.gameObject.SetActive(true);
                TableCardText3.gameObject.SetActive(true);
                Card3.gameObject.SetActive(true);
               
                break;
            default:
                TableCardImage3.gameObject.SetActive(false);
                TableCardText3.gameObject.SetActive(false);
                Card3.gameObject.SetActive(false);
                break;
        }
        switch (JoinTable.CardOnBoardSuit4)
        {
            case "c":
                TableCardImage4.sprite = CardsClubs;
                TableCardImage4.gameObject.SetActive(true);
                TableCardText4.gameObject.SetActive(true);
                Card4.gameObject.SetActive(true);
           
                break;
            case "d":
                TableCardImage4.sprite = CardsDiamond;
                TableCardImage4.gameObject.SetActive(true);
                TableCardText4.gameObject.SetActive(true);
                Card4.gameObject.SetActive(true);
               
                break;
            case "h":
                TableCardImage4.sprite = CardsHearts;
                TableCardImage4.gameObject.SetActive(true);
                TableCardText4.gameObject.SetActive(true);
                Card4.gameObject.SetActive(true);
               
                break;
            case "s":
                TableCardImage4.sprite = CardsSpades;
                TableCardImage4.gameObject.SetActive(true);
                TableCardText4.gameObject.SetActive(true);
                Card4.gameObject.SetActive(true);
                
                break;
            default:
                TableCardImage4.gameObject.SetActive(false);
                TableCardText4.gameObject.SetActive(false);
                Card4.gameObject.SetActive(false);
                break;
        }

        /* switch (JoinTable.CardOnBoardSuit)
         {
             case "c":
                 imagecard.sprite = CardsClubs;
                 imagecard.gameObject.SetActive(true);
                 textcard.gameObject.SetActive(true);
                 Card.gameObject.SetActive(true);
                 break;
             case "d":
                 imagecard.sprite = CardsDiamond;
                 imagecard.gameObject.SetActive(true);
                 textcard.gameObject.SetActive(true);
                 Card.gameObject.SetActive(true);
                 break;
             case "h":
                 imagecard.sprite = CardsHearts;
                 imagecard.gameObject.SetActive(true);
                 textcard.gameObject.SetActive(true);
                 Card.gameObject.SetActive(true);
                 break;
             case "s":
                 imagecard.sprite = CardsSpades;
                 imagecard.gameObject.SetActive(true);
                 textcard.gameObject.SetActive(true);
                 Card.gameObject.SetActive(true);
                 break;
             default:
                 imagecard.gameObject.SetActive(false);
                 textcard.gameObject.SetActive(false);
                 Card.gameObject.SetActive(true);
                 break;
         }

         switch (JoinTable.CardOnBoardSuit)
         {
             case "c":
                 imagecard.sprite = CardsClubs;
                 imagecard.gameObject.SetActive(true);
                 textcard.gameObject.SetActive(true);
                 Card.gameObject.SetActive(true);
                 break;
             case "d":
                 imagecard.sprite = CardsDiamond;
                 imagecard.gameObject.SetActive(true);
                 textcard.gameObject.SetActive(true);
                 Card.gameObject.SetActive(true);
                 break;
             case "h":
                 imagecard.sprite = CardsHearts;
                 imagecard.gameObject.SetActive(true);
                 textcard.gameObject.SetActive(true);
                 Card.gameObject.SetActive(true);
                 break;
             case "s":
                 imagecard.sprite = CardsSpades;
                 imagecard.gameObject.SetActive(true);
                 textcard.gameObject.SetActive(true);
                 Card.gameObject.SetActive(true);
                 break;
             default:
                 imagecard.gameObject.SetActive(false);
                 textcard.gameObject.SetActive(false);
                 Card.gameObject.SetActive(true);
                 break;
         }*/
    }
}
