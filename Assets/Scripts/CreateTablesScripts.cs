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

public class CreateTablesScripts : MonoBehaviour
{
    public GameObject Canvas; //Основной Canvas чи куда 
    public GameObject Tabless; // Создаваемый объект;
    public GameObject scrip;
    void Start()
    {
        int index = 3; //от 0 до максимального размера иерархии
        int yCoord = -150;
        int yCoord2 = -250;
        GameObject _delta = Tabless;
        for (int i = 0; i<3; i++)
        {
            _delta = Instantiate(Tabless) as GameObject;
            if (i == 0)
            {
                _delta.transform.position = transform.position + new Vector3(0, yCoord, 0);
            }
            else
            {
                _delta.transform.position = transform.position + new Vector3(0, yCoord + (yCoord2 * i), 0);
            }
            Button btn = _delta.GetComponent<Button>();
            _delta.transform.SetParent(Canvas.transform, false);
            _delta.transform.SetSiblingIndex(index); //SetAsLastSibling() для того чтобы сделать объект "ближним" в иерархии или SetAsFirstSibling() наоборот.
        }
    }

    void Update()
    {
        
    }
}
