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

public class AvaibleOnTableScript : MonoBehaviour
{
    public GameObject PrefabPeopleOther;
    // Start is called before the first frame update
  void Start ()
    {


        PrefabPeopleOther.gameObject.SetActive(false);



    }

    // Update is called once per frame
    void Update()
    {


        if (JoinTable.AvaibleTableOther == 0)
        {

            PrefabPeopleOther.gameObject.SetActive(false);




        }


        if (JoinTable.AvaibleTableOther == 1)
        {

            PrefabPeopleOther.gameObject.SetActive(true);




        }


    }
}
