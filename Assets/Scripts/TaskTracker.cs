using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskTracker : MonoBehaviour
{
    [SerializeField]
    private int tasks;
    private bool finishedAll = false;

    public void FinishTask()
    {
        tasks -= 1;
    }

    public void AddTask()
    {
        tasks += 1;
    }

    public bool Isfinished()
    {
        return finishedAll;
    }
    private void FixedUpdate()
    {
        if (tasks <= 0)
        {
            finishedAll = true;
            FindObjectOfType<CompleteCheck>().CheckTrackers();
        }
    }
}
