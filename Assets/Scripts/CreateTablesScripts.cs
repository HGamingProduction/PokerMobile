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
    public GameObject Canvas; //�������� Canvas �� ���� 
    public GameObject Tabless; // ����������� ������;
    public GameObject scrip;
    void Start()
    {
        int index = 3; //�� 0 �� ������������� ������� ��������
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
            _delta.transform.SetSiblingIndex(index); //SetAsLastSibling() ��� ���� ����� ������� ������ "�������" � �������� ��� SetAsFirstSibling() ��������.
        }
    }

    void Update()
    {
        
    }
}
