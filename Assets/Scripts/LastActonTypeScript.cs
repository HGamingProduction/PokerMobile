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
    public GameObject LastActionTypeMy;
    public GameObject LastActionTypeOther;
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



       
        

    }
}
