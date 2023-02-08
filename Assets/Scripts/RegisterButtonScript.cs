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

public class RegisterButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void GoToRegister()
    {
        SceneManager.LoadScene(3);
    }

    
    
}
