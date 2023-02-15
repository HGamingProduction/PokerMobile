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
    public GameObject Canvas; //Основний Canvas чи куди закинути об'єкт
    public GameObject Tabless; // Створюємий об'єкт;
    public GameObject scrip; //Обє'кт з скриптом на приєднання до столів
    public RectTransform rectTransform;
    void Start()
    {
        Glob.TotalTables = 0;
    }

    void Update()
    {
        if (Glob.TotalTables == 0)
        {
            GameObject _canvas = Canvas;
            GameObject _delta = Tabless;
            for (int i = 0; i < FindAllTables.TotalTables; i++)
            {
                int index = 3+i; //Положення об'єкта
                int yCoord = -150;
                int yCoord2 = -250;
                int yCoord3 = 370;
                var cmp = scrip.GetComponent<JoinTable>(); //Отримати скрипт який знаходиться в об'єкті
                rectTransform = _canvas.GetComponent<RectTransform>(); //Отримати компонент RectTransform який знаходиться в 
                _delta = Instantiate(Tabless) as GameObject;
                if (i == 0)
                {
                    _delta.transform.position = transform.position + new Vector3(0, yCoord, 0);  //Створити об'єкт столів на дефолтних координатах
                    rectTransform.sizeDelta = new Vector2(rectTransform.sizeDelta.x, rectTransform.sizeDelta.y + yCoord3);
                }
                else
                {
                    _delta.transform.position = transform.position + new Vector3(0, yCoord + (yCoord2 * i), 0); //Створити об'єкти столів на нижчих координатах ніж попередній стіл
                    rectTransform.sizeDelta = new Vector2(rectTransform.sizeDelta.x, rectTransform.sizeDelta.y + (yCoord2 * -1));
                }
                _delta.transform.SetParent(Canvas.transform, false);
                _delta.transform.SetSiblingIndex(index); //SetAsLastSibling() для того чтобы сделать объект "ближним" в иерархии или SetAsFirstSibling() наоборот.
                _delta = GameObject.FindWithTag("GameController"); //Знаходить кнопку в якій тег "GameController"
                _delta.transform.gameObject.tag = "Untagged"; //Змінює тег кнопки на "Untagged"
                _delta.AddComponent<JoinTable>();  //Додає в кнопку компонент JoinTable який являється скриптом    ---- цю строку можна і не писати
                Button btn = _delta.GetComponent<Button>();  //Додає в змінну btn (яка типу Button) компонент Button
                btn.onClick.AddListener(cmp.JoinTablePoker); //Додає дію на onClick а саме нашу функції (JoinTablePoker) в скрипті (JoinTable)
                Glob.TotalTables = 1;  //Дає змінній TotalTables (в якій 1-вже вивели столи, 0-ще не виводили столи)
            }
        }
    }
}
