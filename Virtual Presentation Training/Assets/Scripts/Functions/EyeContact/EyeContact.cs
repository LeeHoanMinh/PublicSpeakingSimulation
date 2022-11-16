using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeContact : MonoBehaviour
{
    public GameObject Left, MLeft, Right, MRight;
    private void Awake()
    {
        Left = GameObject.Find("Left");
        Right = GameObject.Find("Right");
        MLeft = GameObject.Find("MLeft");
        MRight = GameObject.Find("MRight");
    }
    public int ECTracking()
    {
        float leftHitless = 0, rightHitless = 0;
        leftHitless += Mathf.Abs(Left.GetComponent<HitView>().durationWait);
        leftHitless += Mathf.Abs(MLeft.GetComponent<HitView>().durationWait);
        rightHitless += Mathf.Abs(Right.GetComponent<HitView>().durationWait);
        rightHitless += Mathf.Abs(MRight.GetComponent<HitView>().durationWait);
        if (leftHitless > rightHitless)
        { 
            Debug.Log("left");
            return 0;
        }
        else
        {
            Debug.Log("right");
            return 1;
        }
    }
}
