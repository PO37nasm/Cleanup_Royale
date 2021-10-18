using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteCheck : MonoBehaviour
{
    [SerializeField]
    private GameObject winUI;
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
        //Pause the game and display the Win menu, telling the PauseMenu script to not accept escape inputs to prevent possible overlap
        Time.timeScale = 0f;
        winUI.SetActive(true);
        GameOverMenu.GameIsOver = true;
        PauseMenu.GameIsPaused = true;
    }
}
