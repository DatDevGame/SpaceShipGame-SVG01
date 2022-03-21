using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBackground : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    Vector2 moveY = new Vector2(0f, -1f);

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveGround();
    }

    public void moveGround()
    {
        if (Player.ins.currentHealthPlayer > 0)
        {
            this.rb.velocity = moveY * speed * Time.fixedDeltaTime;
        }
        else

        this.rb.velocity = moveY * 0;
    }

}
