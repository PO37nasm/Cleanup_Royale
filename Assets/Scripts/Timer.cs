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

    private void Start()
    {
        startTime = Time.fixedTime;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        timer.text = "" + Mathf.RoundToInt(arriveTime - (Time.fixedTime - startTime));
        if (Time.timeSinceLevelLoad > arriveTime)
        {
            timer.gameObject.SetActive(false);
            GetComponent<GameOverMenu>().GameOver();
        }
    }
}
