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

public class SceneCreateTable : MonoBehaviour
{
    public Slider slider1;
    public Text ValueSlider1;
    public Slider slider2;
    public Text ValueSlider2;
    void Update()
    {
        ValueSlider1.text = Convert.ToString(slider1.value);
        ValueSlider2.text = Convert.ToString(slider2.value * 10);
    }
}