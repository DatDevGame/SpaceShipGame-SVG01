using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreText : MonoBehaviour
{
    AudioSource aus;
    public AudioClip soundExplosion;

    public static scoreText insScore;
    public Text setScoreText;

    public int m_Score;
    // Start is called before the first frame update
    private void Awake()
    {
        insScore = this;
    }
    void Start()
    {
        aus = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
   
    public void setScore()
    {
        aus.PlayOneShot(soundExplosion);
        m_Score++;
        setScoreText.text = "Score: " + m_Score;
    }


}
