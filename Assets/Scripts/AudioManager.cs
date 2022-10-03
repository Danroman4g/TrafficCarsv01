using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static bool crush;
    public AudioSource crushsound;
    //AudioSource audioSource;

    public AudioSource audioSource;
    public AudioClip clip;
    public float volume = 0.5f;


    private void Start()
    {
        crush = false;
        //audioSource = GetComponent<AudioSource>;
    }


    public void Update()
    {
        if (crush) AudioCrush();
    }


    public void AudioCrush()
    {
       
        
        audioSource.PlayOneShot(clip, volume);
        
    }
}
