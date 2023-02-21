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

        string Umailtext = Glob.GlobalEmails;
        string Unametext = Convert.ToString(Uname.text);
        var jsona = new Rootrt
        {
            eventType = "update_user",
            updateUser = new UpdateUser { email = Umailtext, name = Unametext, chips = 69696969}
        };
        string message = JsonConvert.SerializeObject(jsona);
        Debug.Log(message);
        MainWebSocket.ws.Send(message);
    }
}

public class Rootrt
{
    public string eventType { get; set; }
    public UpdateUser updateUser { get; set; }
}

public class UpdateUser
{
    public string email { get; set; }
    public string name { get; set; }
    public int chips { get; set; }
}

