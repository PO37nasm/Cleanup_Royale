using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Weapon") && collision != null)
        {
            // alert that weapon can be picked up
            if (Input.GetButton("Fire1") && collision != null)
            {
                GetComponentInParent<Inventory>().AddWeapon(collision.GetComponent<SpriteRenderer>().sprite);
                GetComponentInParent<Animator>().Play("PutDownPickUp");
                GetComponentInParent<Movement>().freeze();
                StartCoroutine(waitForPickup(collision));
            }
        }
    }

    IEnumerator waitForPickup(Collider2D collision)
    {
        if (collision != null)
        {
            yield return new WaitForSeconds(0.4f);
            finishPickup(collision);
        }

    }

    void finishPickup(Collider2D collision)
    {
        GetComponentInParent<Movement>().unfreeze();
        if (collision != null)
        {
            Destroy(collision.gameObject);
        }
    }
}
