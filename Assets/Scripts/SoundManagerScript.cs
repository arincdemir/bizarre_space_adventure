using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static SoundManagerScript instance;

    public AudioSource aSource;
    public AudioClip menuBg;
    public AudioClip gameBg;
    public AudioClip explosionClip;
    public AudioClip asteroidCollisionClip;

    // Start is called before the first frame update
    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MenuBackground()
    {
        aSource.PlayOneShot(menuBg, PlayerPrefs.GetFloat("MusicLoudness"));
    }

    public void GameBackground()
    {
        aSource.PlayOneShot(gameBg, PlayerPrefs.GetFloat("MusicLoudness"));
    }

    public void Explosion()
    {
        aSource.PlayOneShot(explosionClip, PlayerPrefs.GetFloat("SoundEffectsLoudness"));
    }

    public void AsteroidCollision()
    {
        aSource.PlayOneShot(asteroidCollisionClip, PlayerPrefs.GetFloat("SoundEffectsLoudness"));
    }
}
