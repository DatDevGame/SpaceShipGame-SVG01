using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketPlayer : MonoBehaviour
{
    protected float SpeedRocket;
    Vector2 moveRocket = new Vector2();
    void Start()
    {
        Destroy(gameObject, 5f);
        SpeedRocket = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        moveRocketPlayer();
    }
    public void moveRocketPlayer()
    {
        moveRocket = Vector2.up * SpeedRocket * Time.deltaTime;
        transform.Translate(moveRocket);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("DestroyBullet"))
        {
            Destroy(gameObject);
        }

        if (other.gameObject.CompareTag("Enemy"))
        {
            //damage Enemy
            Enemy hitDamage = other.gameObject.GetComponent<Enemy>();
            hitDamage.takeDame(9999);
            Destroy(gameObject, 2f);
        }

        if (other.gameObject.CompareTag("Enemy2"))
        {
            //damage Enemy
            Enemy hitDamage = other.gameObject.GetComponent<Enemy>();
            hitDamage.takeDame(9999);
            Destroy(gameObject, 2f);
        }

        if (other.gameObject.CompareTag("Enemy3"))
        {
            //damage Enemy
            Enemy hitDamage = other.gameObject.GetComponent<Enemy>();
            hitDamage.takeDame(9999);
            Destroy(gameObject, 2f);
        }

        if (other.gameObject.CompareTag("Boss1"))
        {
            //damage Enemy
            Enemy hitDamage = other.gameObject.GetComponent<Enemy>();
            hitDamage.takeDame(200);
            Destroy(gameObject);
        }
    }
}
