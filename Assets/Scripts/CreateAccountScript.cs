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


public class CreateAccountScript : MonoBehaviour
{
    public InputField takelogin;
    public InputField takepassword;
    public InputField takename;
    public InputField takepasswordclone;
    public async void CreateAccountButton()
    {

        string registeremail = (takelogin.text);
        string registerpassword = (takepassword.text);
        string registername = (takename.text);
        string registerpasswordclone = (takepasswordclone.text);
        HttpClient httpClient = new HttpClient();


        var jsona = new CreateButtonScript
        {
            email = registeremail,
            password = registerpassword,
            name = registername
        };
        string message = JsonConvert.SerializeObject(jsona);

        StringContent content = new StringContent(message);

        var request = new HttpRequestMessage(HttpMethod.Post, "https://poker.grassbusinesslabs.tk/api/register");

        request.Content = content;

        var response = await httpClient.SendAsync(request);
        string responseText = await response.Content.ReadAsStringAsync();

        Debug.Log(responseText);

       if (registerpassword == registerpasswordclone)
        {

            SceneManager.LoadScene(0);

        };
       if ( registerpassword != registerpasswordclone)
        {



            Debug.Log("WrongPassword? try aggain");
        };


    }
}

public class CreateButtonScript
{
    
    public string email { get; set; }

    
    public string name { get; set; }
    public string password { get; set; }

}
