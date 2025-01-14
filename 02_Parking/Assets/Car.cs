using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{

    float 速度 = 0;
    Vector2 起點;

    void Start()
    {
    }

    void Update()
    {

        // 取得滑動長度
        if (Input.GetMouseButtonDown(0))
        {
            // 點擊滑鼠時座標
            this.起點 = Input.mousePosition; 
        }
        else if (Input.GetMouseButtonUp(0))
        {
            // 放開滑鼠時座標
            Vector2 終點 = Input.mousePosition;  
            float 滑鼠移動距離 = 終點.x - this.起點.x;
            this.速度 = 滑鼠移動距離 / 2000.0f;  // 把滑動長度轉換成初始移動速度
            GetComponent<AudioSource>().Play(); // 播放音效
        }

        transform.Translate(this.速度, 0, 0);
        this.速度 *= 0.98f;
    }
}