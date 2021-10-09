using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cleaning : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Dirt"))
        {
            Debug.Log("On Dirt");
            if (Input.GetButton("Fire1"))
            {
                Destroy(collision.gameObject);
            }
            

        }
    }

}
