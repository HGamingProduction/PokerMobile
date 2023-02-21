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


/*email = "user1@test.com", password = "12345678"*/


public class LoginButton : MonoBehaviour
{
    public InputField sendlogin;
    public InputField sendpassword;


    public async void JoinPoker()
    {
        
        string loginemail = (sendlogin.text);
        string loginpassword = (sendpassword.text);
        HttpClient httpClient = new HttpClient();

        var jsona = new Jsona
        {
            email = loginemail,
            password = loginpassword
        };
        string message = JsonConvert.SerializeObject(jsona);

        StringContent content = new StringContent(message);

        var request = new HttpRequestMessage(HttpMethod.Post, "https://poker.grassbusinesslabs.tk/api/login");

        request.Content = content;

        var response = await httpClient.SendAsync(request);
        string responseText = await response.Content.ReadAsStringAsync();

        Debug.Log(responseText);

        var currency = JsonConvert.DeserializeObject<Jsona>(responseText);
        Glob.GlobalEmails = currency.user.email;
        Debug.Log(currency.user.email);
        string example = (currency.token);

        string exampleurl = "wss://poker.grassbusinesslabs.tk/api/?jwt=";
        Glob.websocketurl = exampleurl + example;
        /*Debug.Log(Glob.websocketurl);*/
        Glob.GlobalId = currency.user.id;
        Glob.GlobalName = currency.user.name;
        Glob.GlobalChips = currency.user.chips;
        if (example == currency.token)
        {
            SceneManager.LoadScene(1);
        };

        
    }
}
public class Test
{
    [Newtonsoft.Json.JsonProperty("User")]
    public new Jsona user { get; set; }



}
public class Jsona : Test
{
    [Newtonsoft.Json.JsonProperty("Email")]
    public string email { get; set; }
    public int id { get; set; }
    [Newtonsoft.Json.JsonProperty("Token")]
    public string token { get; set; }
    public string password { get; set; }
    public string name { get; set; }
    public int chips { get; set; }
}
