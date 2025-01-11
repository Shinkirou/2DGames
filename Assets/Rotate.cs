using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    float 旋轉速度 = 0;  

    void Start()
    {

    }

    void Update()
    {
        // 若點擊滑鼠開始旋轉
        if (Input.GetMouseButtonDown(0))
        {
            旋轉速度 = 10;
        }

        // 讓輪盤旋轉
        transform.Rotate(0, 0, 旋轉速度);

        // 輪盤減速(動畫)
        旋轉速度 *= 0.99f;
    }
}
