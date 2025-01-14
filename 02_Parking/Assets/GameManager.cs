using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // 使用 UI 物件，必須增加此處理程序

public class GameManager : MonoBehaviour
{
    GameObject 車子;             // 用來儲存汽車物件
    GameObject 旗子;             // 用來儲存旗子物件
    GameObject 距離;             // 用來儲存UI文字物件

    void Start() 
    {
        車子 = GameObject.Find("car");
        旗子 = GameObject.Find("flag");
        距離 = GameObject.Find("Distance");
    }

    void Update()
    {
        // 計算旗子與汽車的距離
        float 旗子與汽車距離 = 旗子.transform.position.x - 車子.transform.position.x;
        // 將旗子與汽車的距離顯示在UI上面
        距離.GetComponent<Text>().text = "距離目標還有 " + 旗子與汽車距離.ToString("F2") + "m";
    }
}
