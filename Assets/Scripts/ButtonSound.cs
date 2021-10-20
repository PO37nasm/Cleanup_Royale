using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSound : MonoBehaviour
{
    [SerializeField]
    private AudioClip hoverSound;
    [SerializeField]
    private AudioClip clickSound;
    private void OnMouseEnter()
    {
        GetComponentInParent<AudioSource>().PlayOneShot(hoverSound);
    }

    private void OnMouseUpAsButton()
    {
        GetComponentInParent<AudioSource>().PlayOneShot(clickSound);
    }
}
