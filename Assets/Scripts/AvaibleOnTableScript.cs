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
    public GameObject PrefabPeopleOther2;
    public GameObject PrefabPeopleOther3;
    public GameObject PrefabPeopleOther4;
    public GameObject PrefabPeopleOther5;
    public GameObject PrefabPeopleOther6;
    public GameObject PrefabPeopleOther7;
    public GameObject PrefabPeopleOther8;
    public GameObject PrefabPeopleOther9;
    // Start is called before the first frame update
    void Start ()
    {


       



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


        if (JoinTable.AvaibleTableOther2 == 0)
        {

            PrefabPeopleOther2.gameObject.SetActive(false);




        }


        if (JoinTable.AvaibleTableOther2 == 1)
        {

            PrefabPeopleOther2.gameObject.SetActive(true);






        }


        if (JoinTable.AvaibleTableOther3 == 0)
        {

            PrefabPeopleOther3.gameObject.SetActive(false);




        }


        if (JoinTable.AvaibleTableOther3 == 1)
        {

            PrefabPeopleOther3.gameObject.SetActive(true);




        }


        if (JoinTable.AvaibleTableOther4 == 0)
        {

            PrefabPeopleOther4.gameObject.SetActive(false);




        }


        if (JoinTable.AvaibleTableOther4 == 1)
        {

            PrefabPeopleOther4.gameObject.SetActive(true);




        }



        if (JoinTable.AvaibleTableOther5 == 0)
        {

            PrefabPeopleOther5.gameObject.SetActive(false);




        }


        if (JoinTable.AvaibleTableOther5 == 1)
        {

            PrefabPeopleOther5.gameObject.SetActive(true);




        }


        if (JoinTable.AvaibleTableOther6 == 0)
        {

            PrefabPeopleOther6.gameObject.SetActive(false);




        }


        if (JoinTable.AvaibleTableOther6 == 1)
        {

            PrefabPeopleOther6.gameObject.SetActive(true);




        }

        if (JoinTable.AvaibleTableOther7 == 0)
        {

            PrefabPeopleOther7.gameObject.SetActive(false);




        }


        if (JoinTable.AvaibleTableOther7 == 1)
        {

            PrefabPeopleOther7.gameObject.SetActive(true);




        }

        if (JoinTable.AvaibleTableOther8 == 0)
        {

            PrefabPeopleOther8.gameObject.SetActive(false);




        }


        if (JoinTable.AvaibleTableOther8 == 1)
        {

            PrefabPeopleOther8.gameObject.SetActive(true);




        }

        if (JoinTable.AvaibleTableOther9 == 0)
        {

            PrefabPeopleOther9.gameObject.SetActive(false);




        }


        if (JoinTable.AvaibleTableOther9 == 1)
        {

            PrefabPeopleOther9.gameObject.SetActive(true);




        }
    }
}
