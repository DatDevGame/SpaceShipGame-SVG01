using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemRockets : MonoBehaviour
{
    Rigidbody2D rb;

    Vector2 moveRocket;
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 0.01f;
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

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Player RocketEarn = other.gameObject.GetComponent<Player>();
            RocketEarn.GetRocket(1);
            Destroy(gameObject);
        }


    }
}
