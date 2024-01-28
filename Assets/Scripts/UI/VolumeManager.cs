using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class VolumeManager : MonoBehaviour
{
    public Slider _musicSlider, _SFXSlider;
    public Volume_Manager volumeManager;
    public bag bag;
    private void Update()
    {
        volumeManager.musicVolume = _musicSlider.value;
        volumeManager.SFXVolume = _SFXSlider.value;
        Debug.Log(_musicSlider.value);
    }
    private void Start()
    {
        _musicSlider.value= volumeManager.musicVolume;
        _SFXSlider.value= volumeManager.SFXVolume;
    }

    public void ToggleMusic()
    {
        AudioManager.Instance.ToggleMusic();
    }
    public void ToggleSFX()
    {
        AudioManager.Instance.ToggleSFX();
    }
    public void MusicVolume()
    {
        AudioManager.Instance.MusicVolume(_musicSlider.value);
    }
    public void SFXVolume()
    {
        AudioManager.Instance.SFXVolume(_SFXSlider.value);
    }
    public void clearBag()
    {
        bag.items.Clear();
    }
}
