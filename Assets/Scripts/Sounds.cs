using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    public AudioClip GameStartSound;
    public AudioClip HitSound;
    public AudioClip HopSound;
    public static Sounds Instance;

    private AudioSource audioSource;

    private void Awake()
    {
        if (Instance != null && Instance != this)
            Destroy(this.gameObject);
        else
            Instance = this;
    }

    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    public void PlayGameStartSound()
    {
        audioSource.PlayOneShot(GameStartSound);
    }

    public void PlayHitSound()
    {
        audioSource.PlayOneShot(HitSound);
    }

    public void PlayHopSound()
    {
        audioSource.PlayOneShot(HopSound);
    }
}
