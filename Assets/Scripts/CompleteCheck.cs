using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteCheck : MonoBehaviour
{
    [SerializeField]
    private GameObject winUI;
    [SerializeField]
    private AudioClip winSound;
    private TaskTracker[] trackers;
    private bool timeToLeave = false;
    private void Start()
    {
        trackers = FindObjectsOfType<TaskTracker>();
    }
    public void CheckTrackers()
    {
        timeToLeave = true;
        foreach (TaskTracker tracker in trackers)
        {
            if (!tracker.Isfinished() && !tracker.isExit)
            {
                timeToLeave = false;
            }
        }
        if (timeToLeave)
        {
            Debug.Log("Should appear");
            FindObjectOfType<ObjectivePointer>().Appear();
        }
        foreach (TaskTracker tracker in trackers)
        { 
            if (!tracker.Isfinished())
            {
                return;
            }
        }
        //Pause the game and display the Win menu, telling the PauseMenu script to not accept escape inputs to prevent possible overlap
        Time.timeScale = 0f;
        GetComponent<AudioSource>().PlayOneShot(winSound);
        winUI.SetActive(true);
        GameOverMenu.GameIsOver = true;
        PauseMenu.GameIsPaused = true;
    }
}
