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

public class CardsOnTableViewScript : MonoBehaviour
{
    [SerializeField] private Text CardsInTableView;
    [SerializeField] private Text CardsInTableView1;
    [SerializeField] private Text CardsInTableView2;
    [SerializeField] private Text CardsInTableView3;
    [SerializeField] private Text CardsInTableView4;

    // Start is called before the first frame update
    void Start()
    {
        CardsInTableView.text = JoinTable.CardOnTable1;
        CardsInTableView1.text = JoinTable.CardOnTable2;
        CardsInTableView2.text = JoinTable.CardOnTable3;
        CardsInTableView3.text = JoinTable.CardOnTable4;
        CardsInTableView4.text = JoinTable.CardOnTable5;
    }

    // Update is called once per frame
    void Update()
    {
        CardsInTableView.text = JoinTable.CardOnTable1;
            CardsInTableView1.text = JoinTable.CardOnTable2;
               CardsInTableView2.text = JoinTable.CardOnTable3;
                 CardsInTableView3.text = JoinTable.CardOnTable4;
                    CardsInTableView4.text = JoinTable.CardOnTable5;
    }
}
