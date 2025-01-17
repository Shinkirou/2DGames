using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // 使用 LoadScene 必要的引用程式敘述 !!

public class Cat : MonoBehaviour
{
    Rigidbody2D CatrRigid2D;
    Animator CatAnimator;

    public float 跳躍力 = 340.0f;
    public float 步行距離 = 30.0f;
    public float 最大步距 = 2.0f;

    void Start()
    {
        CatrRigid2D = GetComponent<Rigidbody2D>();  // 取得貓咪的剛體
        CatAnimator = GetComponent<Animator>();     // 取得貓咪的動畫
    }

    void Update()
    {
        // 跳躍
        if (Input.GetKeyDown(KeyCode.Space) && this.CatrRigid2D.velocity.y == 0)
        {
            CatAnimator.SetTrigger("Jump");
            CatrRigid2D.AddForce(transform.up * 跳躍力);
        }


        // 左右移動
        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow))
            key = 1;
        if (Input.GetKey(KeyCode.LeftArrow))
            key = -1;

        // 遊戲角色的速度
        float speedx = Mathf.Abs(this.CatrRigid2D.velocity.x);

        // 速度限制
        if (speedx < this.最大步距)
        {
            CatrRigid2D.AddForce(transform.right * key * 步行距離);
        }

        // 依遊戲角色的速度改變動畫的速度
        if (CatrRigid2D.velocity.y == 0)
        {
            CatAnimator.speed = speedx / 2.0f;
        }
        else
        {
            CatAnimator.speed = 1.0f;
        }


        // 依照行進方向翻轉(轉向效果)
        if (key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }
    }

    // 抵達終點
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
