using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeCountDown : MonoBehaviour
{
    GameObject textObject;
    int tmp,minutes,second;
    void Start()
    {
        minutes = 11;
        second = 50;
        textObject = GameObject.Find("Timing");
        InvokeRepeating("TimeCountdown", 2.0f, 1f);
    }

    // Update is called once per frame
    void TimeCountdown()
    {
        second--;
        if(second == -1)
        {
            minutes--;
            second = 59;
        }
        textObject.GetComponent<TextMesh>().text = minutes + ":" + second;
    }
}
