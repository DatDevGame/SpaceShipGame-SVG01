using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBulletEmemy : MonoBehaviour
{
    public float movespeed ;
    Vector2 moveYBullet = new Vector2();

    //Make Damage to Player
    public float makeDamage = 20f;

    //Create effect Bullet
    public GameObject effectBulletEnemy;

    private void Awake()
    {

    }
    void Start()
    {
        movespeed = 5f;
        Destroy(gameObject, 3);
    }

    // Update is called once per frame
    void Update()
    {
        moveBulletEnemy();
    }

    public void moveBulletEnemy()
    {
        moveYBullet = Vector2.down * movespeed * Time.deltaTime;
        transform.Translate(moveYBullet);
    }


    //Make Damage to Player
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Instantiate(effectBulletEnemy, transform.position, Quaternion.identity);
            Player hitPlayer = other.gameObject.GetComponent<Player>();
            hitPlayer.receiveDamagePlayer(makeDamage);
            Destroy(gameObject);
        }

        if (other.gameObject.CompareTag("Shield"))
        {
            Destroy(gameObject);
        }
        if (other.gameObject.CompareTag("GunManager"))
        {
            Destroy(gameObject, 2f);
        }
    }
}
