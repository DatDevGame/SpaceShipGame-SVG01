using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeBoss : MonoBehaviour
{
    Rigidbody2D rb;

    float speed = 1f;
    Vector2 moveBoss = new Vector2();

    float timer = 5f;


    private void Awake()
    {

    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movementBoss();
    }
    
    public void movementBoss()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            return;
        }    
        else
        {
            this.moveBoss = Vector2.left * speed * Time.deltaTime;
            transform.Translate(moveBoss);
        }
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("RoundLeftBoss"))
        {
            speed = -1f;
        }
        if (other.gameObject.CompareTag("RoundRightBoss"))
        {
            speed = 1f;
        }
    }

    IEnumerator times()
    {
        yield return new WaitForSeconds(3);  
    }
}
