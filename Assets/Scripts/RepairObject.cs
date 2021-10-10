using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepairObject : MonoBehaviour
{

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Broken") && Input.GetButton("Fire1"))
        {
            if (collision.GetComponent<Door>() != null)
            {
                collision.GetComponent<Door>().Repair();
                GetComponent<DoorInteract>().lastDoorInteraction = Time.fixedTime;
            }

            //code for repairing windows etc
        }
    }
}
