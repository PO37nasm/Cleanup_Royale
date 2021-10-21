using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
public class ItemSpot : MonoBehaviour
{
    private bool filled = false;

    public bool isFilled()
    {
        return filled;
    }

    public void fill()
    {
        filled = true;
        gameObject.tag = "Untagged";
        GetComponentInParent<TaskTracker>().FinishTask();
        GetComponent<Light2D>().lightCookieSprite = GetComponent<SpriteRenderer>().sprite;
        GetComponent<Light2D>().color = new Color(3, 214, 95);
        GetComponent<Light2D>().intensity = 0.004f;

    }


}
