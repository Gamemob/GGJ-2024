using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/new Item")]
public class itemForBag : ScriptableObject
{
    public Sprite ItemSprite;
    public float ChangeNum;//对发笑条的影响
}
