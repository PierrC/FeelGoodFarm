using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTrigger : MonoBehaviour
{
    public AudioClip triggerBeachSound;
    AudioSource audioSource;
    public float fadeOutFactor = 0.2f;
    public float fadeInFactor = 0.2f;

    private bool fadeInOut = false;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (audioSource.volume <= 0.0f) { audioSource.Stop(); }
        if (audioSource.volume >= 0.1f) {
            if (audioSource.isPlaying == false)
            {
                audioSource.PlayOneShot(triggerBeachSound, 0.1f);
            }
        
        }
        if (fadeInOut == true)
        {
            if (audioSource.volume < 1.0f)
            {
                audioSource.volume += fadeInFactor * Time.deltaTime;
            }
        }

        if (fadeInOut == false)
        {
            if (audioSource.volume > 0.0f)
            {
                audioSource.volume -= fadeOutFactor * Time.deltaTime;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("collision tag:" + collision.tag);
        if (collision.tag == "Player")
        {
            Debug.Log("Correct tag");
            fadeInOut = true;
            //audioSource.PlayOneShot(triggerBeachSound, 0.1f);
            //fadeIn();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        //if (audioSource.volume <= 0.0f)
        //{
            fadeInOut = false;
            //audioSource.Stop();
        //}

    }

 /*   public void fadeIn()
    {
        if (audioSource.volume < 1.0f)
        {
            audioSource.volume = audioSource.volume + 0.1f * Time.deltaTime;
        }
    }

    public void fadeOut()
    {
        if (audioSource.volume > 0.0f)
        {
            audioSource.volume = audioSource.volume - 0.1f * Time.deltaTime;
        }
    }*/
}
