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
            if (Input.GetButton("Fire1") && collision != null && GameManager.inputEnabled == true)
            {
                GetComponentInParent<Inventory>().AddWeapon(collision.gameObject);
                collision.gameObject.SetActive(false);
                GetComponentInParent<Animator>().Play("PutDownPickUp");
                GetComponentInParent<Movement>().freeze();
                GameManager.inputEnabled = false;
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
        if (collision != null)
        {
            GetComponentInParent<Movement>().unfreeze();
            GameManager.inputEnabled = true;
        }
    }
}
