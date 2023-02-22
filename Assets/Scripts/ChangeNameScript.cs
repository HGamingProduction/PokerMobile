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

public class ChangeNameScript : MonoBehaviour
{
    [SerializeField] private Text NameMyChange;
    [SerializeField] private Text NameOtherChange;
    [SerializeField] private Text NameOtherChange2;
    [SerializeField] private Text NameOtherChange3;
    [SerializeField] private Text NameOtherChange4;
    [SerializeField] private Text NameOtherChange5;
    [SerializeField] private Text NameOtherChange6;
    [SerializeField] private Text NameOtherChange7;
    [SerializeField] private Text NameOtherChange8;
    [SerializeField] private Text NameOtherChange9;
    // Start is called before the first frame update
    void Start()
    {
        NameMyChange.text = JoinTable.MyName;
        NameOtherChange.text = JoinTable.OtherName;
        NameOtherChange2.text = JoinTable.OtherName2;
        NameOtherChange3.text = JoinTable.OtherName3;
        NameOtherChange4.text = JoinTable.OtherName4;
        NameOtherChange5.text = JoinTable.OtherName5;
        NameOtherChange6.text = JoinTable.OtherName6;
        NameOtherChange7.text = JoinTable.OtherName7;
        NameOtherChange8.text = JoinTable.OtherName8;
        NameOtherChange9.text = JoinTable.OtherName9;
    }

    // Update is called once per frame
    void Update()
    {
        NameMyChange.text = JoinTable.MyName;
        NameOtherChange.text = JoinTable.OtherName;
        NameOtherChange2.text = JoinTable.OtherName2;
        NameOtherChange3.text = JoinTable.OtherName3;
        NameOtherChange4.text = JoinTable.OtherName4;
        NameOtherChange5.text = JoinTable.OtherName5;
        NameOtherChange6.text = JoinTable.OtherName6;
        NameOtherChange7.text = JoinTable.OtherName7;
        NameOtherChange8.text = JoinTable.OtherName8;
        NameOtherChange9.text = JoinTable.OtherName9;
    }
}
