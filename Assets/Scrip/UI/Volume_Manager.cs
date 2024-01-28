using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.InputSystem;
using UnityEngine;
[CreateAssetMenu(fileName = "New Music", menuName = "Inventory/music")]

public class Volume_Manager : ScriptableObject
{
    public float musicVolume;
    public float SFXVolume;
}
