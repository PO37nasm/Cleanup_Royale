using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class Door: MonoBehaviour
{
    // 0 = closed, 1 = open, 2 = broken
    [SerializeField]
    public int state = 0;
    [SerializeField]
    BoxCollider2D closedCollider;
    [SerializeField]
    Sprite brokenSprite;
    [SerializeField]
    Sprite normalSprite;
    private void Start()
    {
        switch (state)
        {
            case 0:
                break;
            case 1:
                GetComponent<Animator>().SetBool("Open", true);
                closedCollider.enabled = false;
                break;
            case 2:
                GetComponent<Animator>().SetBool("Broken", true);
                closedCollider.enabled = false;
                break;
        }
    }

    public void Open()
    {
        if (state != 2)
        {
            state = 1;
            GetComponentInParent<TaskTracker>().AddTask();
            GetComponent<Animator>().SetBool("Open", true);
            closedCollider.enabled = false;
            // Debug.Log("Door Opened");
        }
    }
    public void Close()
    {
        if (state != 2)
        {
            state = 0;
            GetComponentInParent<TaskTracker>().FinishTask();
            GetComponent<Animator>().SetBool("Open", false);
            closedCollider.enabled = true;
            //Debug.Log("Door Closed");
        }
    }

    public void Repair()
    { 
        if (state == 2)
        {
            state = 0;
            gameObject.tag = "Door";
            closedCollider.enabled = true;
            GetComponentInParent<TaskTracker>().FinishTask();
            GetComponentInChildren<Light2D>().enabled = false;
            GetComponent<Animator>().SetBool("Broken", false);
            GetComponent<Animator>().SetBool("Open", false);
            //GetComponent<SpriteRenderer>().sprite = normalSprite;
            //Debug.Log("Door Repaired");
        }
    }

    //public void Break()
    //{
        
    //}
}
