using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{

    float �t�� = 0;
    Vector2 �_�I;

    void Start()
    {
    }

    void Update()
    {

        // ���o�ưʪ���
        if (Input.GetMouseButtonDown(0))
        {
            // �I���ƹ��ɮy��
            this.�_�I = Input.mousePosition; 
        }
        else if (Input.GetMouseButtonUp(0))
        {
            // ��}�ƹ��ɮy��
            Vector2 ���I = Input.mousePosition;  
            float �ƹ����ʶZ�� = ���I.x - this.�_�I.x;
            this.�t�� = �ƹ����ʶZ�� / 2000.0f;  // ��ưʪ����ഫ����l���ʳt��
            GetComponent<AudioSource>().Play(); // ���񭵮�
        }

        transform.Translate(this.�t��, 0, 0);
        this.�t�� *= 0.98f;
    }
}