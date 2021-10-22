using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer: MonoBehaviour
{
    [SerializeField]
    private float arriveTime = 10f;
    private float startTime = 0f;
    [SerializeField]
    private TMP_Text timer;
    [SerializeField]
    private AudioClip loseSound;
    [SerializeField]
    private AudioClip countDown;
    private bool countDownStarted = false;

    private void Start()
    {
        startTime = Time.fixedTime;
        countDownStarted = false;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        timer.text = "" + Mathf.RoundToInt(arriveTime - (Time.fixedTime - startTime));
        if (Time.timeSinceLevelLoad > arriveTime)
        {
            timer.gameObject.SetActive(false);
            GetComponent<AudioSource>().PlayOneShot(loseSound);
            GetComponent<GameOverMenu>().GameOver();
        }
        if (Time.timeSinceLevelLoad > arriveTime - 11 && !countDownStarted)
        {
            GetComponent<AudioSource>().PlayOneShot(countDown);
            countDownStarted = true;
        }
    }
}
