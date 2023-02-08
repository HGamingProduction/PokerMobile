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

public class CardsViewScript : MonoBehaviour
{


    [SerializeField] private Text CardsText;
    [SerializeField] private Text CardsText2;
    // Start is called before the first frame update
    void Start()
    {
        CardsText.text = JoinTable.MyPocket;
        CardsText2.text = JoinTable.MyPocket2;
    }

    // Update is called once per frame
    void Update()
    {
        CardsText.text = JoinTable.MyPocket;
        CardsText2.text = JoinTable.MyPocket2;

        
    }
}
