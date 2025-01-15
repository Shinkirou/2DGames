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
        // �C�Ӽv�浥�t���U����
        transform.Translate(0, -0.1f, 0);

        // �W�X�C���e����R��
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
