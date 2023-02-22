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
    public GameObject OtherPlayerActionPrefab2;
    public GameObject OtherPlayerActionPrefab3;
    public GameObject OtherPlayerActionPrefab4;
    public GameObject OtherPlayerActionPrefab5;
    public GameObject OtherPlayerActionPrefab6;
    public GameObject OtherPlayerActionPrefab7;
    public GameObject OtherPlayerActionPrefab8;
    public GameObject OtherPlayerActionPrefab9;
    void Start()
    {
        MyPlayerActionPrefab.gameObject.SetActive(false);
        OtherPlayerActionPrefab.gameObject.SetActive(false);
        OtherPlayerActionPrefab2.gameObject.SetActive(false);
        OtherPlayerActionPrefab3.gameObject.SetActive(false);
        OtherPlayerActionPrefab4.gameObject.SetActive(false);
        OtherPlayerActionPrefab5.gameObject.SetActive(false);
        OtherPlayerActionPrefab6.gameObject.SetActive(false);
        OtherPlayerActionPrefab7.gameObject.SetActive(false);
        OtherPlayerActionPrefab8.gameObject.SetActive(false);
        OtherPlayerActionPrefab9.gameObject.SetActive(false);
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


        if (JoinTable.FirstGlobalAvaibleActions2 == 0)
        {
            OtherPlayerActionPrefab2.gameObject.SetActive(false);

        }
        else { OtherPlayerActionPrefab2.gameObject.SetActive(true); }


        if (JoinTable.FirstGlobalAvaibleActions3 == 0)
        {
            OtherPlayerActionPrefab3.gameObject.SetActive(false);

        }
        else { OtherPlayerActionPrefab3.gameObject.SetActive(true); }


        if (JoinTable.FirstGlobalAvaibleActions4 == 0)
        {
            OtherPlayerActionPrefab4.gameObject.SetActive(false);

        }
        else { OtherPlayerActionPrefab4.gameObject.SetActive(true); }



        if (JoinTable.FirstGlobalAvaibleActions5 == 0)
        {
            OtherPlayerActionPrefab5.gameObject.SetActive(false);

        }
        else { OtherPlayerActionPrefab5.gameObject.SetActive(true); }

        


        if (JoinTable.FirstGlobalAvaibleActions6 == 0)
        {
            OtherPlayerActionPrefab6.gameObject.SetActive(false);

        }
        else { OtherPlayerActionPrefab6.gameObject.SetActive(true); }




        if (JoinTable.FirstGlobalAvaibleActions7 == 0)
        {
            OtherPlayerActionPrefab7.gameObject.SetActive(false);

        }
        else { OtherPlayerActionPrefab7.gameObject.SetActive(true); }
        



        if (JoinTable.FirstGlobalAvaibleActions8 == 0)
        {
            OtherPlayerActionPrefab8.gameObject.SetActive(false);

        }
        else { OtherPlayerActionPrefab8.gameObject.SetActive(true); }




        if (JoinTable.FirstGlobalAvaibleActions9 == 0)
        {
            OtherPlayerActionPrefab9.gameObject.SetActive(false);

        }
        else { OtherPlayerActionPrefab9.gameObject.SetActive(true); }



    }
}
