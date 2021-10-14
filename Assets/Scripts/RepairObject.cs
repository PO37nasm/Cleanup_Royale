using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepairObject : MonoBehaviour
{

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Broken") && collision != null)
        {
            if (Input.GetButton("Fire1"))
            {
                GetComponentInParent<Animator>().Play("Repair");
                GetComponentInParent<Movement>().freeze();
                StartCoroutine(waitForRepair(collision));
            }
        }
    }

    IEnumerator waitForRepair(Collider2D collision)
    {
        if (collision != null)
        {
            yield return new WaitForSeconds(1);
            finishRepair(collision);
        }
    }

    private void finishRepair(Collider2D collision)
    {
        GetComponentInParent<Movement>().unfreeze();
        if (collision.GetComponent<Door>() != null)
        {
            collision.GetComponent<Door>().Repair();
            GetComponent<DoorInteract>().lastDoorInteraction = Time.fixedTime;
        }
        //code for repairing windows etc
    }
}
