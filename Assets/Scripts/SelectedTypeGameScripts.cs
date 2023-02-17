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

public class SelectedTypeGameScripts : MonoBehaviour
{
    public Dropdown dropdown;
    public Dropdown dropdown2;
    public static string selectedOption;
    void Start()
    {
        dropdown.value = 0;
        int selectedValue = dropdown.value;
        selectedOption = dropdown.options[selectedValue].text;
        dropdown.onValueChanged.AddListener(delegate { DropdownValueChanged(dropdown); });
    }
    void DropdownValueChanged(Dropdown change)
    {
        int selectedValue = dropdown.value;
        selectedOption = dropdown.options[selectedValue].text;
    }
    void Update()
    {
        if (selectedOption == "GAME")
        {
            dropdown2.interactable = false;
        }
        else
        {
            dropdown2.interactable = true;
        }
    }
}
