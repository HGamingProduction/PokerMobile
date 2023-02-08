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

    // Start is called before the first frame update
    void Start()
    {
        ChipsText.text = Convert.ToString(JoinTable.NumberChips);

        ChipsTextTwo.text = Convert.ToString(JoinTable.NumberChipsTwo);

        CurrentBets.text = Convert.ToString(JoinTable.CurrentBet);
        CurrentBetTwos.text = Convert.ToString(JoinTable.CurrentBetTwo);
    }

    // Update is called once per frame
    void Update()
    {
        ChipsText.text = Convert.ToString(JoinTable.NumberChips);


        ChipsTextTwo.text = Convert.ToString(JoinTable.NumberChipsTwo);

        CurrentBets.text = Convert.ToString(JoinTable.CurrentBet);
        CurrentBetTwos.text = Convert.ToString(JoinTable.CurrentBetTwo);
    }
}
