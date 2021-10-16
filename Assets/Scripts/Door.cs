using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        if (state == 2)
        {
            GetComponent<Animator>().SetBool("Broken", true);
            //gameObject.tag = "Broken";
            //GetComponent<SpriteRenderer>().sprite = brokenSprite;
        }
    }

    public void Open()
    {
        state = 1;
        GetComponent<Animator>().Play("Open");
        closedCollider.enabled = false;
       // Debug.Log("Door Opened");
    }
    public void Close()
    {
        state = 0;
        GetComponent<Animator>().Play("Close");
        closedCollider.enabled = true;
        //Debug.Log("Door Closed");
    }

    public void Repair()
    {
        state = 0;
        gameObject.tag = "Door";
        closedCollider.enabled = true;
        GetComponent<Animator>().SetBool("Broken", false);
        GetComponent<Animator>().Play("Close");
        //GetComponent<SpriteRenderer>().sprite = normalSprite;
        //Debug.Log("Door Repaired");
    }

    //public void Break()
    //{
        
    //}
}
