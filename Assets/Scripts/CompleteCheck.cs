using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteCheck : MonoBehaviour
{
    private TaskTracker[] trackers;
    private void Start()
    {
        trackers = FindObjectsOfType<TaskTracker>();
    }
    public void CheckTrackers()
    {
        foreach (TaskTracker tracker in trackers)
        { 
            if (!tracker.Isfinished())
            {
                return;
            }
        }
        Debug.Log("WIN");
    }
}
