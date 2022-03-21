using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerBullet : MonoBehaviour
{

    public GameObject effectBulletEnemy;
    protected float speed;
    Vector2 moveBullet = new Vector2();
    // Start is called before the first frame update
    void Start()
    {
        speed = 3f;
        Destroy(gameObject, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        MoveBullet();
    }

    public void MoveBullet()
    {
        moveBullet = Vector2.down * speed * Time.deltaTime;

        transform.Translate(moveBullet);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Instantiate(effectBulletEnemy, transform.position, Quaternion.identity);
            Player hitPlayer = other.gameObject.GetComponent<Player>();
            hitPlayer.receiveDamagePlayer(50);
            Destroy(gameObject);
        }
    }
}
