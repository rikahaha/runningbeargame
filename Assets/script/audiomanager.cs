using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiomanager : MonoBehaviour
{
    public AudioClip soundClip;
    private AudioSource audioSource;


    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = soundClip;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        PlayCoinSound();

    }
    


    void PlayCoinSound()
    {
        audioSource.Play();
    }
}