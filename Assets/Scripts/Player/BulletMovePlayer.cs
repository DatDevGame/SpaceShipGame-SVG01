using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovePlayer : MonoBehaviour
{

    public float speedBullet = 10f;
    Vector2 moveBullet = new Vector2(0f, 1f);


    //Create Effect Explosion Bullet
    public GameObject bulletEffect;

    //Damege Enemy
    float receiveDamage = 25f;
    float receiveDamage2 = 15f;
    float receiveDamage3 = 10f;
    float receiveDamageBoss1 = 1f;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        moveBulletPlayer();
    }

    public void moveBulletPlayer()
    {
        transform.Translate(moveBullet * speedBullet * Time.fixedDeltaTime);
    }


    public void OnTriggerEnter2D(Collider2D other)
    {
        //Destroy Bullet
        if(other.gameObject.CompareTag("DestroyBullet"))
        {
            Destroy(gameObject);
        }

        if (other.gameObject.CompareTag("Enemy"))
        {
            //damage Enemy
            Instantiate(bulletEffect, transform.position, Quaternion.identity);
            Enemy hitDamage = other.gameObject.GetComponent<Enemy>();
            hitDamage.takeDame(receiveDamage);
            Destroy(gameObject, 0.03f);
        }

        if (other.gameObject.CompareTag("Enemy2"))
        {
            //damage Enemy
            Instantiate(bulletEffect, transform.position, Quaternion.identity);
            Enemy hitDamage = other.gameObject.GetComponent<Enemy>();
            hitDamage.takeDame(receiveDamage2);
            Destroy(gameObject, 0.03f);
        }

        if (other.gameObject.CompareTag("Enemy3"))
        {
            //damage Enemy
            Instantiate(bulletEffect, transform.position, Quaternion.identity);
            Enemy hitDamage = other.gameObject.GetComponent<Enemy>();
            hitDamage.takeDame(receiveDamage3);
            Destroy(gameObject, 0.03f);
        }

        if (other.gameObject.CompareTag("Boss1"))
        {
            //damage Enemy
            Instantiate(bulletEffect, transform.position, Quaternion.identity);
            Enemy hitDamage = other.gameObject.GetComponent<Enemy>();
            hitDamage.takeDame(receiveDamageBoss1);
            Destroy(gameObject, 0.03f);
        }
    }


}
