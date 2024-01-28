using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;//¾²Ì¬³ÉÔ± 
    public Sound[] MusicSounds, SfxSounds;
    public AudioSource musicSource, sfxSource;
/*    public Slider MusicVolume;*/

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        if(SceneManager.GetActiveScene().buildIndex>=0&& SceneManager.GetActiveScene().buildIndex <= 4)
        {
            PlayMusic("title");
            StopMusic("Defeat");
        }
        else if (SceneManager.GetActiveScene().buildIndex == 5)
        {
            PlayMusic("Defeat");
        }
        else if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            PlayMusic("Victory");
        }
        /*MusicVolume.value = musicSource.volume;
        MusicVolume.onValueChanged.AddListener(delegate { VolumeManger(); });*/
    }

    public void PlayMusic(string name)
    {
        Sound s = Array.Find(MusicSounds, x => x.name == name);
        if (s == null)
        {
            Debug.Log(1);
            Debug.Log("Sound Not Found");
        }
        else
        {
            musicSource.clip = s.clip;
            musicSource.Play();
        }
    }
    public void StopMusic(string name)
    {
        Sound s = Array.Find(MusicSounds, x => x.name == name);
        if (s == null)
        {
            Debug.Log(1);
            Debug.Log("Sound Not Found");
        }
        else
        {
            musicSource.clip = s.clip;
            musicSource.Stop();
        }
    }

    public void PlaySFX(string name)
    {
        Sound s = Array.Find(SfxSounds, x => x.name == name);
        if (s == null)
        {
            Debug.Log(2);
            Debug.Log("Sound Not Found");
        }
        else
        {
            Debug.Log("Play");
            sfxSource.clip = s.clip;
            sfxSource.PlayOneShot(s.clip);
        }
    }
    public void ToggleMusic()
    {
        musicSource.mute=!musicSource.mute;
    }
    public void ToggleSFX()
    {
        sfxSource.mute=!sfxSource.mute;    
    }
    public void MusicVolume(float volume)
    {
        musicSource.volume = volume;
    }
    public void SFXVolume(float volume)
    {
        sfxSource.volume = volume;
    }

}
