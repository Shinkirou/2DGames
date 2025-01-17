using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // �ϥ� LoadScene ���n���ޥε{���ԭz !!

public class Cat : MonoBehaviour
{
    Rigidbody2D CatrRigid2D;
    Animator CatAnimator;

    public float ���D�O = 340.0f;
    public float �B��Z�� = 30.0f;
    public float �̤j�B�Z = 2.0f;

    void Start()
    {
        CatrRigid2D = GetComponent<Rigidbody2D>();  // ���o�߫}������
        CatAnimator = GetComponent<Animator>();     // ���o�߫}���ʵe
    }

    void Update()
    {
        // ���D
        if (Input.GetKeyDown(KeyCode.Space) && this.CatrRigid2D.velocity.y == 0)
        {
            CatAnimator.SetTrigger("Jump");
            CatrRigid2D.AddForce(transform.up * ���D�O);
        }


        // ���k����
        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow))
            key = 1;
        if (Input.GetKey(KeyCode.LeftArrow))
            key = -1;

        // �C�����⪺�t��
        float speedx = Mathf.Abs(this.CatrRigid2D.velocity.x);

        // �t�׭���
        if (speedx < this.�̤j�B�Z)
        {
            CatrRigid2D.AddForce(transform.right * key * �B��Z��);
        }

        // �̹C�����⪺�t�ק��ܰʵe���t��
        if (CatrRigid2D.velocity.y == 0)
        {
            CatAnimator.speed = speedx / 2.0f;
        }
        else
        {
            CatAnimator.speed = 1.0f;
        }


        // �̷Ӧ�i��V½��(��V�ĪG)
        if (key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }
    }

    // ��F���I
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
