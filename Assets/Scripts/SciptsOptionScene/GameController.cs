using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    AudioSource aus;
    public AudioClip mouseClick;
    // Start is called before the first frame update
    void Start()
    {
        aus = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Playbtn()
    {
        aus.PlayOneShot(mouseClick);
        aus.Stop();
        SceneManager.LoadScene("PlayerScene");
    }
    public void Quit()
    {
        aus.PlayOneShot(mouseClick);
        Application.Quit();
    }
}
