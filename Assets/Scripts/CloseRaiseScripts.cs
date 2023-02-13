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

public class CloseRaiseScripts : MonoBehaviour
{
    public Button ButtonOpen;
    public Button ButtonClose;
    public GameObject MenuRaise;
    public async void OpenRaiseAction()
    {
        MenuRaise.SetActive(true);
    }
    public async void CloseRaiseAction()
    {
        MenuRaise.SetActive(false);
    }
}
