using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    float ����t�� = 0;  

    void Start()
    {

    }

    void Update()
    {
        // �Y�I���ƹ��}�l����
        if (Input.GetMouseButtonDown(0))
        {
            ����t�� = 10;
        }

        // �����L����
        transform.Rotate(0, 0, ����t��);

        // ���L��t(�ʵe)
        ����t�� *= 0.99f;
    }
}
