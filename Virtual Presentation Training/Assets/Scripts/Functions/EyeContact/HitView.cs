using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitView : MonoBehaviour
{
    public GameObject GameManager, LAr, RAr;
    public float maxWaitTime; 

    public bool isHit = false;
    public float durationHit, durationWait;

    private void Awake()
    {
        GameManager = GameObject.Find("GameManager");
    }
    private void Update()
    {
        if (isHit)
        {
            if (durationHit < 0)    //changing from unhit to hit
                durationHit = 0;
            durationHit += Time.deltaTime;
        }
        else
        {
            if (durationHit > 0)
                durationHit = 0;
            durationHit -= Time.deltaTime;
        }
        OnWaitingLook();
    }
    public void OnHit()
    {       
        if (this.gameObject.name == "Left" && LAr.activeSelf)
        {
            LAr.SetActive(false);
        }
        if (this.gameObject.name == "Right" && RAr.activeSelf)
        {
            RAr.SetActive(false);
        }
        isHit = true;
        durationWait = -.01f;
    }
    public void OnUnHit()
    {
        isHit = false;
    }
    void OnWaitingLook()
    {
        if (durationHit < -maxWaitTime && durationHit < 0)
        {
            if (durationWait < 0)
                durationWait = 0f;
            durationWait += Time.deltaTime;
            //Debug.Log("Hey, look " + this.gameObject.name);
        }
    }
}
