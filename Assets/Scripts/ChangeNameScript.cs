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
    // Start is called before the first frame update
    void Start()
    {
        NameMyChange.text = JoinTable.MyName;
        NameOtherChange.text = JoinTable.OtherName;
        NameOtherChange2.text = JoinTable.OtherName2;
        NameOtherChange3.text = JoinTable.OtherName3;
    }

    // Update is called once per frame
    void Update()
    {
        NameMyChange.text = JoinTable.MyName;
        NameOtherChange.text = JoinTable.OtherName;
        NameOtherChange2.text = JoinTable.OtherName2;
        NameOtherChange3.text = JoinTable.OtherName3;
    }
}
