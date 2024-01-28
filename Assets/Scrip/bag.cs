using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New BAG", menuName = "Inventory/new bag")]
public class bag : ScriptableObject
{
    public List<itemForBag> items = new List<itemForBag>();

}
