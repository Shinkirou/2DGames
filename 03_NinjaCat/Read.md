在Arrow的程式碼新增城市如下
  private void OnCollisionStay2D(Collision2D collision)
      {
          if (collision.gameObject.tag == "Player")
          {
              Destroy(this.gameObject);
          }
      }
這樣可以達到箭頭碰到貓之後消失的效果
