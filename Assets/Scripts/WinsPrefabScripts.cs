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

    public static int WinsPeople = 10;
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
        // Slepoi test
        IdPeopleOnTable[0] = 2;
        IdPeopleOnTable[1] = 0;
        IdPeopleOnTable[2] = 13;
        IdPeopleOnTable[3] = 43;
        IdPeopleOnTable[4] = 63;
        IdPeopleOnTable[5] = 12;
        IdPeopleOnTable[6] = 55;
        IdPeopleOnTable[7] = 23;
        IdPeopleOnTable[8] = 17;
        IdPeopleOnTable[9] = 22;

        UserNamePeopleOnTable[0] = "User0[2]";
        UserNamePeopleOnTable[1] = "User1[0]";
        UserNamePeopleOnTable[2] = "User2[13]";
        UserNamePeopleOnTable[3] = "User3[43]";
        UserNamePeopleOnTable[4] = "User4[63]";
        UserNamePeopleOnTable[5] = "User5[12]";
        UserNamePeopleOnTable[6] = "User6[55]";
        UserNamePeopleOnTable[7] = "User7[23]";
        UserNamePeopleOnTable[8] = "User8[17]";
        UserNamePeopleOnTable[9] = "User9[22]";

        CardsOnTable[0] = "2c";
        CardsOnTable[1] = "2c";
        CardsOnTable[2] = "2c";
        CardsOnTable[3] = "2c";
        CardsOnTable[4] = "2c";

        BestCombinationsWinsPersonal[0] = "2c";
        BestCombinationsWinsPersonal[1] = "2c";
        BestCombinationsWinsPersonal[2] = "2c";
        BestCombinationsWinsPersonal[3] = "2c";
        BestCombinationsWinsPersonal[4] = "2c";
        BestCombinationsWinsPersonal[5] = "2c";
        BestCombinationsWinsPersonal[6] = "2c";
        BestCombinationsWinsPersonal[7] = "2c";
        BestCombinationsWinsPersonal[8] = "2c";
        BestCombinationsWinsPersonal[9] = "2c";


        /*for(int i = 0; i < WinsPeople; i++)
        {
            int jj = 0;
            for (int j = 0; j < 5; j++)
            {
                WinsPrefabScripts.BestCombinationsWinsPersonal[i * 5 + jj] = Winner[i].bestCombination[jj];
                jj++;
            }
            jj = 0;
        }
        for(int j = 0; j < 50; j++)
        {
            Debug.Log(WinsPrefabScripts.BestCombinationsWinsPersonal[j]+j);
        }*/

        PeopleWinsCombinations[0] = "Pair";
        PeopleWinsCombinations[1] = "Pair";

        WinnersOnTable[0] = 13;
        WinnersOnTable[1] = 55;

        WinnersChips[0] = 10;
        WinnersChips[1] = 11;

        PeopleCardsOnTable[0] = "2c";
        PeopleCardsOnTable[1] = "2c";
        PeopleCardsOnTable[2] = "2c";
        PeopleCardsOnTable[3] = "2c";
        PeopleCardsOnTable[4] = "2c";
        PeopleCardsOnTable[5] = "2c";
        PeopleCardsOnTable[6] = "2c";
        PeopleCardsOnTable[7] = "2c";
        PeopleCardsOnTable[8] = "2c";
        PeopleCardsOnTable[9] = "2c";
        PeopleCardsOnTable[10] = "2c";
        PeopleCardsOnTable[11] = "2c";
        PeopleCardsOnTable[12] = "2c";
        PeopleCardsOnTable[13] = "2c";
        PeopleCardsOnTable[14] = "2c";
        PeopleCardsOnTable[15] = "2c";
        PeopleCardsOnTable[16] = "2c";
        PeopleCardsOnTable[17] = "2c";
        PeopleCardsOnTable[18] = "2c";
        PeopleCardsOnTable[19] = "2c";



        //CODE
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

        string? cardText = null;
        string? Suit = null;

        GameObject CardsOnTableObj = GameObject.Find("CardsOnTable");
        for (int i = 0; i <= 4; i++)
        {
            Transform childObjectViewCardImageTable = CardsOnTableObj.transform.Find("ViewCardImage" + (i+1));

            Transform childObjectLightningImageCardTable = childObjectViewCardImageTable.transform.Find("LightningImage");
            Transform childObjectTextCardTable = childObjectViewCardImageTable.transform.Find("NumberCardText");
            Transform childObjectImageCardTable = childObjectViewCardImageTable.transform.Find("ModelCardImage");
            Transform childObjectIdCardOnTable = childObjectViewCardImageTable.transform.Find("IDCards");

            Image imagingLightningImageCardTable = childObjectLightningImageCardTable.GetComponent<Image>();
            Text textingIdCardTable = childObjectIdCardOnTable.GetComponent<Text>();
            Text textingCardTable = childObjectTextCardTable.GetComponent<Text>();
            Image imagingCardTable = childObjectImageCardTable.GetComponent<Image>();

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
                    Suit = Convert.ToString(v);
                }
                switch (Suit)
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

            textingIdPeople.text = Convert.ToString(IdPeopleOnTable[i]);
            textingNameText.text = UserNamePeopleOnTable[i];
            
            textingCardID1.text = PeopleCardsOnTable[i * 2];
            textingCardID2.text = PeopleCardsOnTable[i + (i + 1)];

            if (PeopleCardsOnTable[i*2] != null)
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
                    Suit = Convert.ToString(v);
                }
                switch (Suit)
                {
                    case "c":
                        imagingCard1.sprite = CardsClubs;
                        break;
                    case "d":
                        imagingCard1.sprite = CardsDiamond;
                        break;
                    case "h":
                        imagingCard1.sprite = CardsHearts;
                        break;
                    case "s":
                        imagingCard1.sprite = CardsSpades;
                        break;
                }
            }
            else
            {
                textingCard1.text = null;
                imagingCard1.color = new Color32(0, 0, 0, 0);
            }

            if (PeopleCardsOnTable[i+(i+1)] != null)
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
                    Suit = Convert.ToString(v);
                }
                switch (Suit)
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
