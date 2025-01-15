using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject 箭頭; 
    float 箭頭生成時間 = 1.0f;             
    float 累積時間 = 0;               

    public Image 生命;     //置放血環

    void Update()
    {
        累積時間 += Time.deltaTime; //隨影格增加時間
        if (累積時間 > 箭頭生成時間)  // 只要累積時間大於箭頭生成時間（大於1秒），就會產生一個箭頭
        {
            累積時間 = 0;  //重製累積時間
            int px = Random.Range(-6, 7); // 隨機產生一個-6到7之間的數字
            Instantiate(箭頭, new Vector3(px, 7, 0), Quaternion.identity); // 產生箭頭物件
        }
    }

    // 這是一個用來讓別的程式減少貓咪HP的方法，每次執行一次，Fill Amount 的數值就減少0.1
    public void DecreaseHp()
    {
        生命.GetComponent<Image>().fillAmount -= 0.1f;
        print("被箭頭攻擊");
    }
}
