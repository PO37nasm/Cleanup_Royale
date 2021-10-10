using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteract : MonoBehaviour
{
    public float lastDoorInteraction = 0;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Door") && Input.GetButton("Fire1") && Time.fixedTime - lastDoorInteraction > 0.5)
        {
            //Debug.Log("Interacted with Door");
            Door door = collision.GetComponent<Door>();
            switch (door.state)
            {
                case 0:
                    door.Open();
                    break;
                case 1:
                    door.Close();
                    break;
            }
            lastDoorInteraction = Time.fixedTime;
        }
    }
}
