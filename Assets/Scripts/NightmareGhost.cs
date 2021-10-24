using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightmareGhost : MonoBehaviour
{
    [SerializeField]
    private List<Door> doors;
    private float lastOpening = 0;
    private void FixedUpdate()
    {
        OpenRandomDoor();
    }

    private void OpenRandomDoor()
    {
        int selection = Random.Range(0, doors.Count);
        float selectedTime = Random.Range(2.13f, 6.66f);
        if (Time.fixedTime >= lastOpening + selectedTime && doors[selection].state == 0)
        {
            doors[selection].Open();
            lastOpening = Time.fixedTime;
        }
    }
}
