using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource click;

    public void Start()
    {
        click.Play();
        gameObject.SetActive(false);
        Time.timeScale = 1;

    }

    public void Paused()
    {
        click.Play();
        gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    public void Unpaused()
    {
        click.Play();
        gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}
