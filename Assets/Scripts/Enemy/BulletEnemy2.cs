using UnityEngine;

public class BulletEnemy2 : MonoBehaviour
{
    public GameObject bulletEnemyPrefab;
    public Transform PosGunEnemy1;
    public Transform PosGunEnemy2;
    protected float timer;
    protected float timeDuration;

    private void Start()
    {
        timeDuration = Random.Range(2f, 4f);
        timer = timeDuration;
    }
    private void Update()
    {
        prefabsBullet();
    }

    public void prefabsBullet()
    {
        //Stop spawn Bullt Enemy When Player Dead
        if (Player.ins.currentHealthPlayer <= 0)
            return;

        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Instantiate(bulletEnemyPrefab, PosGunEnemy1.position, PosGunEnemy1.transform.rotation);
            Instantiate(bulletEnemyPrefab, PosGunEnemy2.position, PosGunEnemy2.transform.rotation);
            timer = timeDuration;
        }

    }
}
