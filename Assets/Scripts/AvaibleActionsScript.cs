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

public class AvaibleActionsScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject MyPlayerActionPrefab;
    public GameObject OtherPlayerActionPrefab;
    void Start()
    {
        MyPlayerActionPrefab.gameObject.SetActive(false);
        OtherPlayerActionPrefab.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (JoinTable.MyGlobalAvaibleActions == 0)
        {
            MyPlayerActionPrefab.gameObject.SetActive(false);

        }
        else { MyPlayerActionPrefab.gameObject.SetActive(true); }



        if (JoinTable.FirstGlobalAvaibleActions == 0)
        {
            OtherPlayerActionPrefab.gameObject.SetActive(false);

        }
        else { OtherPlayerActionPrefab.gameObject.SetActive(true); }





    }
}