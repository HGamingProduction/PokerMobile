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

    public Sprite CardsClubs;
    public Sprite CardsDiamond;
    public Sprite CardsHearts;
    public Sprite CardsSpades;

    public static int WinsPeople = 0;
    public static int?[] IdPeopleOnTable = new int?[10];
    public static string?[] UserNamePeopleOnTable = new string?[10];
    public static string?[] CardsOnTable = new string?[5];
    public static string?[] BestCombinationsWinsPersonal = new string?[50];
    public static string?[] PeopleCardsOnTable = new string?[20];
    public static int?[] WinnersOnTable = new int?[10];
    public static int?[] WinnersChips = new int?[10];
    public static string?[] PeopleWinsCombinations = new string?[10];

    void Start()
    {
        
    }

    void Update()
    {
        GameObject _canvas = Canvas;
        rectTransform = _canvas.GetComponent<RectTransform>();

        if (WinsPeople > 4)
        {
            int ii = WinsPeople - 4;
            rectTransform.sizeDelta = new Vector2(rectTransform.sizeDelta.x + (120 * ii), rectTransform.sizeDelta.y);
        }

        Player1.SetActive(false);
        Player2.SetActive(false);
        Player3.SetActive(false);
        Player4.SetActive(false);
        Player5.SetActive(false);
        Player6.SetActive(false);
        Player7.SetActive(false);
        Player8.SetActive(false);
        Player9.SetActive(false);
        Player10.SetActive(false);

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

        string? cardText = null;
        string? Suits = null;

        GameObject CardsOnTableObj = GameObject.Find("CardsOnTabless");
        for (int i = 0; i < 5; i++)
        {
            Transform childObjectViewCardImageTable = CardsOnTableObj.transform.Find("ViewCardImages" + (i + 1));

            Transform childObjectLightningImageCardTable = childObjectViewCardImageTable.transform.Find("LightningImage");
            Transform childObjectTextCardTable = childObjectViewCardImageTable.transform.Find("NumberCardText");
            Transform childObjectImageCardTable = childObjectViewCardImageTable.transform.Find("ModelCardImage");
            Transform childObjectIdCardOnTable = childObjectViewCardImageTable.transform.Find("IDCards");

            Image imagingLightningImageCardTable = childObjectLightningImageCardTable.GetComponent<Image>();
            Text textingIdCardTable = childObjectIdCardOnTable.GetComponent<Text>();
            Text textingCardTable = childObjectTextCardTable.GetComponent<Text>();
            Image imagingCardTable = childObjectImageCardTable.GetComponent<Image>();


            imagingLightningImageCardTable.color = new Color32(0, 0, 0, 0);
            textingIdCardTable.text = CardsOnTable[i];
            if (CardsOnTable[i] != null)
            {
                foreach (char v in CardsOnTable[i])
                {
                    if (v == 'T')
                    {
                        cardText = "10";
                    }
                    else
                    {
                        cardText = Convert.ToString(v);
                    }
                    break;
                }
                textingCardTable.text = cardText;
                foreach (char v in CardsOnTable[i])
                {
                    Suits = Convert.ToString(v);
                }
                switch (Suits)
                {
                    case "c":
                        imagingCardTable.sprite = CardsClubs;
                        break;
                    case "d":
                        imagingCardTable.sprite = CardsDiamond;
                        break;
                    case "h":
                        imagingCardTable.sprite = CardsHearts;
                        break;
                    case "s":
                        imagingCardTable.sprite = CardsSpades;
                        break;
                }
            }
            else
            {
                textingCardTable.text = null;
                imagingCardTable.color = new Color32(0, 0, 0, 0);
            }

            for (int j = 0; j < 50; j++)
            {
                if (textingIdCardTable.text == BestCombinationsWinsPersonal[j])
                {
                    imagingLightningImageCardTable.color = new Color32(255, 196, 0, 166);
                }
                
            }

        }


        GameObject PeopleWinsObj = GameObject.Find("PeopleWins");
        for (int i = 0; i < WinsPeople; i++)
        {
            if (i == 0)
            {
                PeopleWinsObj = GameObject.Find("PeopleWins");
            }
            else
            {
                PeopleWinsObj = GameObject.Find("PeopleWins (" + i + ")");
            }

            Transform childObjectViewLightningImage = PeopleWinsObj.transform.Find("LightningImage");
            Transform childObjectViewNameText = PeopleWinsObj.transform.Find("NameText");
            Transform childObjectViewChipsText = PeopleWinsObj.transform.Find("ChipsText");
            Transform childObjectViewCombinations = PeopleWinsObj.transform.Find("Combination");
            Transform childObjectViewCardImage1 = PeopleWinsObj.transform.Find("ViewCardImage (1)");
            Transform childObjectViewCardImage2 = PeopleWinsObj.transform.Find("ViewCardImage (2)");
            Transform childObjectViewIDPeople = PeopleWinsObj.transform.Find("UID");

            Transform childObjectTextCard1 = childObjectViewCardImage1.transform.Find("NumberCardText");
            Transform childObjectImageCard1 = childObjectViewCardImage1.transform.Find("ModelCardImage");
            Transform childObjectLightningImageCard1 = childObjectViewCardImage1.transform.Find("LightningImage");
            Transform childObjectIdCardOnTable1 = childObjectViewCardImage1.transform.Find("IDCards");

            Transform childObjectTextCard2 = childObjectViewCardImage2.transform.Find("NumberCardText");
            Transform childObjectImageCard2 = childObjectViewCardImage2.transform.Find("ModelCardImage");
            Transform childObjectLightningImageCard2 = childObjectViewCardImage2.transform.Find("LightningImage");
            Transform childObjectIdCardOnTable2 = childObjectViewCardImage2.transform.Find("IDCards");

            Text textingIdPeople = childObjectViewIDPeople.GetComponent<Text>();
            Text textingNameText = childObjectViewNameText.GetComponent<Text>();
            Text textingChipsText = childObjectViewChipsText.GetComponent<Text>();
            Text textingCombinations = childObjectViewCombinations.GetComponent<Text>();
            Image imagingLightningUser = childObjectViewLightningImage.GetComponent<Image>();

            Text textingCard1 = childObjectTextCard1.GetComponent<Text>();
            Text textingCardID1 = childObjectIdCardOnTable1.GetComponent<Text>();
            Image imagingCard1 = childObjectImageCard1.GetComponent<Image>();
            Image imagingLightningImageCardTable1 = childObjectLightningImageCard1.GetComponent<Image>();

            Text textingCard2 = childObjectTextCard2.GetComponent<Text>();
            Text textingCardID2 = childObjectIdCardOnTable2.GetComponent<Text>();
            Image imagingCard2 = childObjectImageCard2.GetComponent<Image>();
            Image imagingLightningImageCardTable2 = childObjectLightningImageCard2.GetComponent<Image>();


            imagingLightningImageCardTable1.color = new Color32(0, 0, 0, 0);
            imagingLightningImageCardTable2.color = new Color32(0, 0, 0, 0);
            textingIdPeople.text = Convert.ToString(IdPeopleOnTable[i]);
            textingNameText.text = UserNamePeopleOnTable[i];

            textingCardID1.text = PeopleCardsOnTable[i * 2];
            textingCardID2.text = PeopleCardsOnTable[i + (i + 1)];

            if (PeopleCardsOnTable[i * 2] != null)
            {
                foreach (char v in PeopleCardsOnTable[i * 2])
                {
                    if (v == 'T')
                    {
                        cardText = "10";
                    }
                    else
                    {
                        cardText = Convert.ToString(v);
                    }
                    break;
                }
                textingCard1.text = cardText;
                foreach (char v in PeopleCardsOnTable[i * 2])
                {
                    Suits = Convert.ToString(v);
                }
                switch (Suits)
                {
                    case "c":
                        imagingCard1.sprite = CardsClubs;
                        imagingCard1.color = new Color32(255, 255, 255, 255);
                        break;
                    case "d":
                        imagingCard1.sprite = CardsDiamond;
                        imagingCard1.color = new Color32(255, 255, 255, 255);
                        break;
                    case "h":
                        imagingCard1.sprite = CardsHearts;
                        imagingCard1.color = new Color32(255, 255, 255, 255);
                        break;
                    case "s":
                        imagingCard1.sprite = CardsSpades;
                        imagingCard1.color = new Color32(255, 255, 255, 255);
                        break;
                }
            }
            else
            {
                textingCard1.text = null;
                imagingCard1.color = new Color32(0, 0, 0, 0);
            }

            if (PeopleCardsOnTable[i + (i + 1)] != null)
            {
                foreach (char v in PeopleCardsOnTable[i + (i + 1)])
                {
                    if (v == 'T')
                    {
                        cardText = "10";
                    }
                    else
                    {
                        cardText = Convert.ToString(v);
                    }
                    break;
                }
                textingCard2.text = cardText;
                foreach (char v in PeopleCardsOnTable[i + (i + 1)])
                {
                    Suits = Convert.ToString(v);
                }
                switch (Suits)
                {
                    case "c":
                        imagingCard2.sprite = CardsClubs;
                        imagingCard2.color = new Color32(255, 255, 255, 255);
                        break;
                    case "d":
                        imagingCard2.sprite = CardsDiamond;
                        imagingCard2.color = new Color32(255, 255, 255, 255);
                        break;
                    case "h":
                        imagingCard2.sprite = CardsHearts;
                        imagingCard2.color = new Color32(255, 255, 255, 255);
                        break;
                    case "s":
                        imagingCard2.sprite = CardsSpades;
                        imagingCard2.color = new Color32(255, 255, 255, 255);
                        break;
                }
            }
            else
            {
                textingCard2.text = null;
                imagingCard2.color = new Color32(0, 0, 0, 0);
            }

            
            for (int j = 0; j < WinsPeople; j++)
            {
                if (WinnersOnTable[j] == IdPeopleOnTable[i])
                {
                    imagingLightningUser.color = new Color32(255, 196, 0, 166);
                    textingChipsText.text = Convert.ToString(WinnersChips[j]);
                    textingCombinations.text = PeopleWinsCombinations[j];

                    for (int jj = 0; jj < 50; jj++)
                    {
                        if (textingCardID1.text == BestCombinationsWinsPersonal[jj])
                        {
                            imagingLightningImageCardTable1.color = new Color32(255, 196, 0, 166);
                        }
                        if (textingCardID2.text == BestCombinationsWinsPersonal[jj])
                        {
                            imagingLightningImageCardTable2.color = new Color32(255, 196, 0, 166);
                        }
                    }
                    break;

                }
                else
                {
                    textingChipsText.text = null;
                    textingCombinations.text = null;
                    imagingLightningUser.color = new Color32(0, 0, 0, 0);
                }
            }


        }
    }
}
