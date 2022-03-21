using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnGround : MonoBehaviour
{
    public Transform spawnPos;
    public GameObject prefabsGround;
    public GameObject PlayerCtrl;

    float countDown;
    public float timer;
    protected float distanceSpawn = 0f;
    protected GameObject currentBackground;

    protected float distanceDestroy = 0f;

    // Start is called before the first frame update
    void Start()
    {
        PlayerCtrl = GameObject.Find("Player");
        this.currentBackground = prefabsGround;
    }

    // Update is called once per frame
    void Update()
    {
        spawnBackground();
    }

    public void spawnBackground()
    {

        this.distanceSpawn = Vector2.Distance(currentBackground.transform.position, PlayerCtrl.transform.position);

        if (this.distanceSpawn <= 50)
        {
            this.currentBackground = Instantiate(prefabsGround, spawnPos.position, Quaternion.identity);
        }
    }
}
