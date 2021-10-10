using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteract : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Door") && Input.GetButtonDown("Fire1"))
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
        }
    }
}
