using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // �ϥ� UI ����A�����W�[���B�z�{��

public class GameManager : MonoBehaviour
{
    GameObject ���l;             // �Ψ��x�s�T������
    GameObject �X�l;             // �Ψ��x�s�X�l����
    GameObject �Z��;             // �Ψ��x�sUI��r����

    void Start() 
    {
        ���l = GameObject.Find("car");
        �X�l = GameObject.Find("flag");
        �Z�� = GameObject.Find("Distance");
    }

    void Update()
    {
        // �p��X�l�P�T�����Z��
        float �X�l�P�T���Z�� = �X�l.transform.position.x - ���l.transform.position.x;
        // �N�X�l�P�T�����Z����ܦbUI�W��
        �Z��.GetComponent<Text>().text = "�Z���ؼ��٦� " + �X�l�P�T���Z��.ToString("F2") + "m";
    }
}
