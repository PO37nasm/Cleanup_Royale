using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Inventory : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> weapons;
    [SerializeField]
    private TMP_Text counter;
    public bool hasWeapon()
    {
        switch (weapons.Count)
        {
            case 0:
                return false;

            default:
                return true;
        }

    }
    public void AddWeapon(GameObject weapon)
    {
        weapons.Add(weapon);
    }

    public GameObject GetWeapon(int index)
    {
        return weapons[index];
    }

    /*public Sprite GetWeaponSprite(int index)
    {
        return weapons[index].GetComponent<SpriteRenderer>().sprite;
    }*/

    public void RemoveWeapon(int index)
    {
        weapons.RemoveAt(index);
        
    }

    private void FixedUpdate()
    {
        counter.text = weapons.Count.ToString();
    }
}
