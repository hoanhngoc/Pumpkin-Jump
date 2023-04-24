using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TMP_Text Scoretext;
    public TMP_Text HightText;
    public float Scoreamount;
    public float pointTime;
    // Start is called before the first frame update
    void Start()
    {
        Scoreamount=Time.time;

    }

    // Update is called once per frame
    void Update()
    {
        Scoretext.text="Time :" +(int)Scoreamount;
        Scoreamount+=Time.deltaTime;

        HightText.text = "Time Waste " + (int)Scoreamount + "second";

    }
}
