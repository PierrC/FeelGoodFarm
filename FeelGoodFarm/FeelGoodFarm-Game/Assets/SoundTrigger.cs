﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTrigger : MonoBehaviour
{
    public AudioClip triggerBeachSound;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("collision tag:" + collision.tag);
        if (collision.tag == "Player")
        {
            Debug.Log("Correct tag");
            audioSource.PlayOneShot(triggerBeachSound, 0.7f);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {

        audioSource.Stop();
    }
}