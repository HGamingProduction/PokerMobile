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

public class Glob : MonoBehaviour
{
    public static string websocketurl;

    public static string POKET;
    public static Timer timer;
    public static TimerCallback tm;
    public static int num = 0;
    public static int GlobalId;
    public static string GlobalName;
    public static string GlobalEmails;
    public static int TotalTables = 0;
    public static bool buttonFoldBool = false;
    public static bool buttonCallBool = false;
    public static bool buttonCheckBool = false;
    public static bool buttonRaiseBool = false;
    /* public static int? NumberChips;*/
}