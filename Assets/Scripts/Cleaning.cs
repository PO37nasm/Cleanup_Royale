using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cleaning : MonoBehaviour
{
    private bool cleaned = false;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Dirt") && collision != null)
        {
            Debug.Log("On Dirt");
            if (Input.GetButton("Fire1"))
            {
                GetComponentInParent<Animator>().Play("Clean");
                GetComponentInParent<Movement>().freeze();
                StartCoroutine(waitForClean(collision));
            }
        }
    }
    IEnumerator waitForClean(Collider2D collision)
    {
        if (collision != null)
        {
            yield return new WaitForSeconds(1);
            finishClean(collision);
        }

    }

    void finishClean(Collider2D collision)
    {
        GetComponentInParent<Movement>().unfreeze();
        if (collision != null)
        {
            Destroy(collision.gameObject);
        }
        
    }
}
