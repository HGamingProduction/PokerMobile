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
    public GameObject Canvas; //�������� Canvas �� ���� �������� ��'���
    public GameObject Tabless; // ���������� ��'���;
    public GameObject scrip; //��'�� � �������� �� ��������� �� �����
    public Text textSeats;
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
            GameObject _delta2 = Tabless;
            GameObject _delta3 = Tabless;
            GameObject _buttonDelete = Tabless;
            Text textId;
            Text textNumber;
            for (int i = 0; i < FindAllTables.TotalTables; i++)
            {
                int index = 3 + i; //��������� ��'����
                int yCoord = -150;
                int yCoord2 = -250;
                int yCoord3 = 370;
                int result = 0;
                var cmp = scrip.GetComponent<JoinTable>(); //�������� ������ ���� ����������� � ��'���
                rectTransform = _canvas.GetComponent<RectTransform>(); //�������� ��������� RectTransform ���� ����������� � 
                _delta = Instantiate(Tabless) as GameObject;
                if (i == 0)
                {
                    _delta.transform.position = transform.position + new Vector3(0, yCoord, 0);  //�������� ��'��� ����� �� ��������� �����������
                    rectTransform.sizeDelta = new Vector2(rectTransform.sizeDelta.x, rectTransform.sizeDelta.y + yCoord3);
                }
                else
                {
                    _delta.transform.position = transform.position + new Vector3(0, yCoord + (yCoord2 * i), 0); //�������� ��'���� ����� �� ������ ����������� ��� ���������� ���
                    rectTransform.sizeDelta = new Vector2(rectTransform.sizeDelta.x, rectTransform.sizeDelta.y + (yCoord2 * -1));
                }
                _delta.transform.SetParent(Canvas.transform, false);
                _delta.transform.SetSiblingIndex(index); //SetAsLastSibling() ��� ���� ����� ������� ������ "�������" � �������� ��� SetAsFirstSibling() ��������.
                _delta2 = _delta;
                _delta2 = GameObject.FindWithTag("Player"); //��������� ��� "Player"
                _delta2.transform.gameObject.tag = "Untagged"; //����� ��� �� "Untagged"
                textId = _delta2.GetComponent<Text>();
                textId.text = Convert.ToString(FindAllTables.IDTables[i]);
                _delta3 = _delta;
                _delta3 = GameObject.FindWithTag("EditorOnly"); //��������� ��� "EditorOnly"
                _delta3.transform.gameObject.tag = "Untagged"; //����� ��� �� "Untagged"
                textNumber = _delta3.GetComponent<Text>();
                result = FindAllTables.CountSeatsInTable[i] - FindAllTables.CountEmptySeatsInTable[i];
                textNumber.text = Convert.ToString(result + "/" + FindAllTables.CountSeatsInTable[i]); 
                _buttonDelete = _delta;
                _buttonDelete = GameObject.FindWithTag("Respawn"); //��������� ��� "Respawn"
                _buttonDelete.transform.gameObject.tag = "Untagged"; //����� ��� �� "Untagged"
                Button btns = _buttonDelete.GetComponent<Button>();
                if (Glob.GlobalId == FindAllTables.CreatorTableId[i])
                {
                    btns.interactable = true;
                }
                _delta = GameObject.FindWithTag("GameController"); //��������� ������ � ��� ��� "GameController"
                _delta.transform.gameObject.tag = "Untagged"; //����� ��� ������ �� "Untagged"
                _delta.AddComponent<JoinTable>();  //���� � ������ ��������� JoinTable ���� ��������� ��������    ---- �� ������ ����� � �� ������
                Button btn = _delta.GetComponent<Button>();  //���� � ����� btn (��� ���� Button) ��������� Button
                btn.onClick.AddListener(cmp.JoinTablePoker); //���� �� �� onClick � ���� ���� ������� (JoinTablePoker) � ������ (JoinTable)



                Glob.TotalTables = 1;  //�� ������ TotalTables (� ��� 1-��� ������ �����, 0-�� �� �������� �����)
            }
        }
    }

}
