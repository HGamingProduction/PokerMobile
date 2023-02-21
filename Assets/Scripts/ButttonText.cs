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

public class ButttonText : MonoBehaviour
{
    public Text buttonText;
    public Text buttonText2;

    public void GetButtonText()
    {
        string text = buttonText.text;
        JoinTable.IdText = text;
        string text2 = buttonText2.text;
        JoinTable.TextArr = text2;
    }
}
