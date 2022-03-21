using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    static public Player ins;
    UIManager m_ui;

    Rigidbody2D rb;
    AudioSource aus;
    public AudioClip SoundBullet;

    //Create Rocket Player
    public GameObject rocketPlayer;

    //Move Player
    float pressHorizontal = 0f;
    float pressVertical = 0f;
    public float moveSpeed = 1f;
    Vector2 velocity = new Vector2(0f, 0f);


    //Health Player
    float maxHealthPlayer = 100f;
    public float currentHealthPlayer;

    //Hearth Slider Player
    public Slider heartSliderPlayer;

    //Player when dead Effect
    public GameObject playerExplosion;


    //Create Shield
    public GameObject shieldActive;
    float timerShield;
    protected float timeDurationShield;



    //Create Rocket Spawn
    public GameObject RocketPrefab;
    public Transform PosRocket;

    public int limitRocket;


    public void Awake()
    {
        aus = GetComponent<AudioSource>();
        Player.ins = this;
    }
    void Start()
    {
       

        currentHealthPlayer = 100f;
        heartSliderPlayer.maxValue = maxHealthPlayer;
        heartSliderPlayer.value = maxHealthPlayer;

        this.rocketPlayer.SetActive(false);
        rb = GetComponent<Rigidbody2D>();

        limitRocket = 2;
        m_ui = FindObjectOfType<UIManager>();
        m_ui.SetRocket("X: " + limitRocket);
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        playerMovent();
        rocketPlayerBehind();
    }
    private void Update()
    {
        SpawnRocketPlayer();
    }
    public void playerMovent()
    {

        this.pressHorizontal = Input.GetAxis("Horizontal");
        this.pressVertical = Input.GetAxis("Vertical");
        this.velocity.x = pressHorizontal * moveSpeed * Time.deltaTime;
        this.velocity.y = pressVertical * moveSpeed * Time.deltaTime;
        this.rb.MovePosition(this.rb.position + velocity);

        if (transform.position.y >= 0) this.velocity.y = -1f;


    }

    //Animation Rocket Player
    public void rocketPlayerBehind()
    {
        if (this.pressVertical > 0)
        {
            this.rocketPlayer.SetActive(true);
        }
        if (this.pressVertical <= 0)
        {
            this.rocketPlayer.SetActive(false);
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        //Create Shield
        if (other.gameObject.CompareTag("ItemShield"))
        {
            shieldActive.SetActive(true);
        }

    }



    //Receeve Damage
    public void receiveDamagePlayer(float receiveDamage)
    {
        currentHealthPlayer -= receiveDamage;
        heartSliderPlayer.value = currentHealthPlayer;
        if (currentHealthPlayer <= 0)
        {
            playerDead();
        }

    }
    public void playerDead()
    {
        Destroy(gameObject);
        Instantiate(playerExplosion, transform.position, Quaternion.identity);
    }

    //Receive Hearth
    public void receiveHearth(float healPlayer)
    {
        currentHealthPlayer += healPlayer;
        if (currentHealthPlayer >= 100)
        {
            currentHealthPlayer = maxHealthPlayer;
        }
        heartSliderPlayer.value = currentHealthPlayer;

    }

   
    public void SpawnRocketPlayer()
    {
        m_ui.SetRocket("X: " + limitRocket);
        if (limitRocket > 0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                limitRocket--;
                Instantiate(RocketPrefab, PosRocket.transform.position, PosRocket.transform.rotation);
            }
        }
    }

    public void GetRocket(int getRocketPlayer)
    {
        limitRocket += getRocketPlayer;
        if (limitRocket >= 2)
        {
            limitRocket = 2;
        }

    }




}
