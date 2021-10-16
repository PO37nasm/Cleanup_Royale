using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceItem : MonoBehaviour
{
    [SerializeField]
    private List<Sprite> consumables;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetButton("Fire1")&& collision.GetComponent<ItemSpot>() != null && !collision.GetComponent<ItemSpot>().isFilled())
        {
            //alert that object can be placed
            if (collision.CompareTag("WeaponSpot") && collision != null)
            {
                collision.GetComponent<SpriteRenderer>().sprite = GetComponentInParent<Inventory>().GetWeapon(0);
                GetComponentInParent<Inventory>().RemoveWeapon(0);
                collision.GetComponent<ItemSpot>().fill();
                GetComponentInParent<Animator>().Play("PutDownPickUp");
                GetComponentInParent<Movement>().freeze();
                StartCoroutine(waitForPlace(collision));
            }
            if (collision.CompareTag("ConsumableSpot") && collision != null)
            {
                int spriteSelect = Random.Range(0, consumables.Count);
                collision.GetComponent<SpriteRenderer>().sprite = consumables[spriteSelect];
                collision.GetComponent<ItemSpot>().fill();
                GetComponentInParent<Animator>().Play("PutDownPickUp");
                GetComponentInParent<Movement>().freeze();
                StartCoroutine(waitForPlace(collision));
            }
        }

    }
    IEnumerator waitForPlace(Collider2D collision)
    {
        if (collision != null)
        {
            yield return new WaitForSeconds(0.4f);
            finishPlace(collision);
        }

    }

    void finishPlace(Collider2D collision)
    {
        GetComponentInParent<Movement>().unfreeze();
        //if (collision != null)
        //{
            
        //
    }
}
