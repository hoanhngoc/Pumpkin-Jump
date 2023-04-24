using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountdownTimer : MonoBehaviour
{
    public float startingTime = 3f;
    private float currentTime;
    private bool hasStarted;
    [SerializeField]  TMP_Text countdownTimeText;

    void Start()
    {
        currentTime = 5;
        hasStarted = false;
        Time.timeScale = 0f;
    }

    void Update()
    {
        if (!hasStarted)
        {
            currentTime -= 1* Time.unscaledDeltaTime;
            countdownTimeText.text = currentTime.ToString("0");
            if (currentTime <= 0)
            {
                hasStarted = true;
                Time.timeScale = 1f;
                gameObject.SetActive(false);
            }
        }
    }
}