using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public GameManager gameManager;

    void Start()
    {

    }

    void Update()
    {
        // 每個影格等速往下移動
        transform.Translate(0, -0.1f, 0);

        // 超出遊戲畫面後刪除
        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
