using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TaskTracker : MonoBehaviour
{
    [SerializeField]
    private int tasks;
    [SerializeField]
    private TMP_Text trackerUI;
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
        trackerUI.text = tasks.ToString();
        if (tasks <= 0)
        {
            finishedAll = true;
            FindObjectOfType<CompleteCheck>().CheckTrackers();
        }
    }
}
