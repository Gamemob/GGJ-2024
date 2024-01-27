using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        PlayMusic("Theme");
        Debug.Log(musicSource.volume);
        /*MusicVolume.value = musicSource.volume;
        MusicVolume.onValueChanged.AddListener(delegate { VolumeManger(); });*/
    }

    public void PlayMusic(string name)
    {
        Sound s = Array.Find(MusicSounds, x => x.name == name);
        if (s == null)
        {
            Debug.Log("Sound Not Found");
        }
        else
        {
            musicSource.clip = s.clip;
            musicSource.Play();
        }
    }

    public void PlaySFX(string name)
    {
        Sound s = Array.Find(SfxSounds, x => x.name == name);
        if (s == null)

        {
            Debug.Log("Sound Not Found");
        }
        else
        {
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
