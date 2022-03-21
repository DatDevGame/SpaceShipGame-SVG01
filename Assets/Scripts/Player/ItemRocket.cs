using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    Rigidbody2D rb;

    Vector2 moveRocket;
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveRocketPlayer();
    }

    public void moveRocketPlayer()
    {
        moveRocket = moveRocket + Vector2.down * speed * Time.deltaTime;
        this.rb.MovePosition(this.rb.position + moveRocket);
    }
}
