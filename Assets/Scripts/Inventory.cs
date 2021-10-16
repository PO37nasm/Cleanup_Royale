using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField]
    private List<Sprite> weapons;

    public void AddWeapon(Sprite weapon)
    {
        weapons.Add(weapon);
    }

    public Sprite GetWeapon(int index)
    {
        return weapons[index];
    }

    /*public Sprite GetWeaponSprite(int index)
    {
        return weapons[index].GetComponent<SpriteRenderer>().sprite;
    }*/

    public void RemoveWeapon(int index)
    {
        //Destroy(weapons[index]);
        weapons.RemoveAt(index);
    }
}
