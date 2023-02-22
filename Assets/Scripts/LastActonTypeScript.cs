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

public class LastActonTypeScript : MonoBehaviour
{
    public Text LastActionText;
    public Text LastActionTextOther;
    public Text LastActionTextOther2;
    public Text LastActionTextOther3;
    public Text LastActionTextOther4;
    public Text LastActionTextOther5;
    public Text LastActionTextOther6;
    public Text LastActionTextOther7;
    public Text LastActionTextOther8;
    public Text LastActionTextOther9;
    public GameObject LastActionTypeMy;
    public GameObject LastActionTypeOther;
    public GameObject LastActionTypeOther2;
    public GameObject LastActionTypeOther3;
    public GameObject LastActionTypeOther4;
    public GameObject LastActionTypeOther5;
    public GameObject LastActionTypeOther6;
    public GameObject LastActionTypeOther7;
    public GameObject LastActionTypeOther8;
    public GameObject LastActionTypeOther9;
    // Start is called before the first frame update
    void Start()
    {
        LastActionTypeMy.gameObject.SetActive(false);
        LastActionTypeOther.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (JoinTable.ActionTypeMy == "NUll")
        {
            LastActionTypeMy.gameObject.SetActive(false);
            

        }

        if (JoinTable.ActionTypeMy != "NUll")
        {
            LastActionTypeMy.gameObject.SetActive(true);
            
            LastActionText.text = JoinTable.ActionTypeMy;
            

        }



        if (JoinTable.ActionTypeOther == "NUll")
        {
            LastActionTypeOther.gameObject.SetActive(false);


        }

        if (JoinTable.ActionTypeOther != "NUll")
        {
            LastActionTypeOther.gameObject.SetActive(true);

            LastActionTextOther.text = JoinTable.ActionTypeOther;


        }


        if (JoinTable.ActionTypeOther2 == "NUll")
        {
            LastActionTypeOther2.gameObject.SetActive(false);


        }

        if (JoinTable.ActionTypeOther2 != "NUll")
        {
            LastActionTypeOther2.gameObject.SetActive(true);

            LastActionTextOther2.text = JoinTable.ActionTypeOther2;


        }

        if (JoinTable.ActionTypeOther3 == "NUll")
        {
            LastActionTypeOther3.gameObject.SetActive(false);


        }

        if (JoinTable.ActionTypeOther3 != "NUll")
        {
            LastActionTypeOther3.gameObject.SetActive(true);

            LastActionTextOther3.text = JoinTable.ActionTypeOther3;


        }

        if (JoinTable.ActionTypeOther4 == "NUll")
        {
            LastActionTypeOther4.gameObject.SetActive(false);


        }

        if (JoinTable.ActionTypeOther4 != "NUll")
        {
            LastActionTypeOther4.gameObject.SetActive(true);

            LastActionTextOther4.text = JoinTable.ActionTypeOther4;


        }

        if (JoinTable.ActionTypeOther5 == "NUll")
        {
            LastActionTypeOther5.gameObject.SetActive(false);


        }

        if (JoinTable.ActionTypeOther5 != "NUll")
        {
            LastActionTypeOther5.gameObject.SetActive(true);

            LastActionTextOther5.text = JoinTable.ActionTypeOther5;


        }

        if (JoinTable.ActionTypeOther6 == "NUll")
        {
            LastActionTypeOther6.gameObject.SetActive(false);


        }

        if (JoinTable.ActionTypeOther6 != "NUll")
        {
            LastActionTypeOther6.gameObject.SetActive(true);

            LastActionTextOther6.text = JoinTable.ActionTypeOther6;


        }

        if (JoinTable.ActionTypeOther7 == "NUll")
        {
            LastActionTypeOther7.gameObject.SetActive(false);


        }

        if (JoinTable.ActionTypeOther7 != "NUll")
        {
            LastActionTypeOther7.gameObject.SetActive(true);

            LastActionTextOther7.text = JoinTable.ActionTypeOther7;


        }

        if (JoinTable.ActionTypeOther8 == "NUll")
        {
            LastActionTypeOther8.gameObject.SetActive(false);


        }

        if (JoinTable.ActionTypeOther8 != "NUll")
        {
            LastActionTypeOther8.gameObject.SetActive(true);

            LastActionTextOther8.text = JoinTable.ActionTypeOther8;


        }

        if (JoinTable.ActionTypeOther9 == "NUll")
        {
            LastActionTypeOther9.gameObject.SetActive(false);


        }

        if (JoinTable.ActionTypeOther9 != "NUll")
        {
            LastActionTypeOther9.gameObject.SetActive(true);

            LastActionTextOther9.text = JoinTable.ActionTypeOther9;


        }





    }
}
