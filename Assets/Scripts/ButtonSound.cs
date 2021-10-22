using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ButtonSound : MonoBehaviour
{
    private Button button { get { return GetComponent<Button>(); } }
    [SerializeField]
    private AudioClip hoverSound;
    [SerializeField]
    private AudioClip clickSound;

    private void OnMouseEnter()
    {
        PlaySound(hoverSound);
    }

    private void OnMouseUpAsButton()
    {
        PlaySound(clickSound);
    }

    private void PlaySound(AudioClip sound)
    {
        GetComponent<AudioSource>().PlayOneShot(sound);
    }
}
