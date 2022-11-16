using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleLookAt : MonoBehaviour
{
    private GameObject target;

    private void Start()
    {
        target = GameObject.Find("VRCamera");
        transform.LookAt(target.transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
