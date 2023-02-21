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

public class ProfileScripts : MonoBehaviour
{
    public static string responceServerss;
    public InputField Uname;
    public InputField Umail;
    void Start()
    {
        Uname.text = Glob.GlobalName;
        Umail.text = Glob.GlobalEmails;
    }

    private static void Ws_OnMessage(object sender, MessageEventArgs e)
    {
        Debug.Log("UpdateUser: " + e.Data);
        responceServerss = e.Data;
    }
    public void UpdateUserButton()
    {
        MainWebSocket.ws.OnMessage += Ws_OnMessage;
        MainWebSocket.ws.Connect();

        string Unametext = (Uname.text);
        string Umailtext = (Umail.text);
        var jsona = new Rootrt
        {
            eventType = "update_user",
            updateUser = new UpdateUser { name = Unametext, email = Umailtext, chips = Glob.GlobalChips}
        };
        string message = JsonConvert.SerializeObject(jsona);
        Debug.Log(message);
        MainWebSocket.ws.Send(message);

        Glob.GlobalName = (Uname.text);
        Glob.GlobalEmails = (Umail.text);
        Uname.text = Glob.GlobalName;
        Umail.text = Glob.GlobalEmails;
    }
}

public class Rootrt
{
    public string eventType { get; set; }
    public UpdateUser updateUser { get; set; }
}

public class UpdateUser
{
    public string name { get; set; }
    public string email { get; set; }
    public int chips { get; set; }
}

