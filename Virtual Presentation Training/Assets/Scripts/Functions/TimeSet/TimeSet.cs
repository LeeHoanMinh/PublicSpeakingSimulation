using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeSet : MonoBehaviour
{
    public float maxTime, curTime;
    public bool endTime()
    {
        if (curTime > maxTime)
            return true;
        else
            return false;
    }
}
