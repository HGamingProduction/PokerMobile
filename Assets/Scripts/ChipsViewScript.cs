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

public class ChipsViewScript : MonoBehaviour
{

    [SerializeField] private Text ChipsText;
    [SerializeField] private Text ChipsTextTwo;
    [SerializeField] private Text CurrentBets;
    [SerializeField] private Text CurrentBetTwos;
    [SerializeField] private Text ChipsTextTwo2;
    [SerializeField] private Text CurrentBetTwos2;
    [SerializeField] private Text ChipsTextTwo3;
    [SerializeField] private Text CurrentBetTwos3;
    [SerializeField] private Text ChipsTextTwo4;
    [SerializeField] private Text CurrentBetTwos4;
    [SerializeField] private Text ChipsTextTwo5;
    [SerializeField] private Text CurrentBetTwos5;
    [SerializeField] private Text ChipsTextTwo6;
    [SerializeField] private Text CurrentBetTwos6;
    [SerializeField] private Text ChipsTextTwo7;
    [SerializeField] private Text CurrentBetTwos7;
    [SerializeField] private Text ChipsTextTwo8;
    [SerializeField] private Text CurrentBetTwos8;
    [SerializeField] private Text ChipsTextTwo9;
    [SerializeField] private Text CurrentBetTwos9;

    // Start is called before the first frame update
    void Start()
    {
        ChipsText.text = Convert.ToString(JoinTable.NumberChips);

        ChipsTextTwo.text = Convert.ToString(JoinTable.NumberChipsTwo);



        CurrentBets.text = Convert.ToString(JoinTable.CurrentBet);
        CurrentBetTwos.text = Convert.ToString(JoinTable.CurrentBetTwo);



        ChipsTextTwo2.text = Convert.ToString(JoinTable.NumberChipsTwo2);
        CurrentBetTwos2.text = Convert.ToString(JoinTable.CurrentBetTwo2);


        ChipsTextTwo3.text = Convert.ToString(JoinTable.NumberChipsTwo3);
        CurrentBetTwos3.text = Convert.ToString(JoinTable.CurrentBetTwo3);

        ChipsTextTwo4.text = Convert.ToString(JoinTable.NumberChipsTwo4);
        CurrentBetTwos4.text = Convert.ToString(JoinTable.CurrentBetTwo4);


        ChipsTextTwo5.text = Convert.ToString(JoinTable.NumberChipsTwo5);
        CurrentBetTwos5.text = Convert.ToString(JoinTable.CurrentBetTwo5);


        ChipsTextTwo6.text = Convert.ToString(JoinTable.NumberChipsTwo6);
        CurrentBetTwos6.text = Convert.ToString(JoinTable.CurrentBetTwo6);


        ChipsTextTwo7.text = Convert.ToString(JoinTable.NumberChipsTwo7);
        CurrentBetTwos7.text = Convert.ToString(JoinTable.CurrentBetTwo7);


        ChipsTextTwo8.text = Convert.ToString(JoinTable.NumberChipsTwo8);
        CurrentBetTwos8.text = Convert.ToString(JoinTable.CurrentBetTwo8);


        ChipsTextTwo8.text = Convert.ToString(JoinTable.NumberChipsTwo8);
        CurrentBetTwos8.text = Convert.ToString(JoinTable.CurrentBetTwo8);

        ChipsTextTwo9.text = Convert.ToString(JoinTable.NumberChipsTwo9);
        CurrentBetTwos9.text = Convert.ToString(JoinTable.CurrentBetTwo9);

    }

    // Update is called once per frame
    void Update()
    {
        ChipsText.text = Convert.ToString(JoinTable.NumberChips);


        ChipsTextTwo.text = Convert.ToString(JoinTable.NumberChipsTwo);

        CurrentBets.text = Convert.ToString(JoinTable.CurrentBet);
        CurrentBetTwos.text = Convert.ToString(JoinTable.CurrentBetTwo);



        ChipsTextTwo2.text = Convert.ToString(JoinTable.NumberChipsTwo2);
        CurrentBetTwos2.text = Convert.ToString(JoinTable.CurrentBetTwo2);


        ChipsTextTwo3.text = Convert.ToString(JoinTable.NumberChipsTwo3);
        CurrentBetTwos3.text = Convert.ToString(JoinTable.CurrentBetTwo3);


        ChipsTextTwo4.text = Convert.ToString(JoinTable.NumberChipsTwo4);
        CurrentBetTwos4.text = Convert.ToString(JoinTable.CurrentBetTwo4);


        ChipsTextTwo5.text = Convert.ToString(JoinTable.NumberChipsTwo5);
        CurrentBetTwos5.text = Convert.ToString(JoinTable.CurrentBetTwo5);


        ChipsTextTwo6.text = Convert.ToString(JoinTable.NumberChipsTwo6);
        CurrentBetTwos6.text = Convert.ToString(JoinTable.CurrentBetTwo6);


        ChipsTextTwo7.text = Convert.ToString(JoinTable.NumberChipsTwo7);
        CurrentBetTwos7.text = Convert.ToString(JoinTable.CurrentBetTwo7);


        ChipsTextTwo8.text = Convert.ToString(JoinTable.NumberChipsTwo8);
        CurrentBetTwos8.text = Convert.ToString(JoinTable.CurrentBetTwo8);


        ChipsTextTwo8.text = Convert.ToString(JoinTable.NumberChipsTwo8);
        CurrentBetTwos8.text = Convert.ToString(JoinTable.CurrentBetTwo8);

        ChipsTextTwo9.text = Convert.ToString(JoinTable.NumberChipsTwo9);
        CurrentBetTwos9.text = Convert.ToString(JoinTable.CurrentBetTwo9);

    }
}
