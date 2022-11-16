using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eye : MonoBehaviour
{
    private GameObject _hitView;
    private float duration;
    private void Awake()
    {
        //init something
    }

    private void Update()
    {

        #region CheckRayCastView
        RaycastHit hit;
        //check direction in real-time
        Debug.DrawRay(this.transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.red, .02f);

        //check region
        if (Physics.Raycast(this.transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            if (hit.collider.gameObject.tag == "View")
            {
                if (_hitView != null)
                {
                    if (hit.collider.gameObject.name != _hitView.name)
                    {
                        //new view looking
                        UnHitView(_hitView);
                        _hitView = hit.collider.gameObject;
                        HitView(_hitView);
                    }
                    else
                    {
                        //stay at old view
                        _hitView = hit.collider.gameObject;
                        HitView(_hitView);
                    }
                }
                else
                {
                    //first time
                    _hitView = hit.collider.gameObject;
                    HitView(_hitView);
                }
            }
        }
        #endregion

    }

    public void HitView(GameObject hitView)
    {
        //Debug.Log("hit:" + hitView.name);
        hitView.GetComponent<HitView>().OnHit();
    }
    public void UnHitView(GameObject hitView)
    {
        //Debug.Log("unhit:" + hitView.name);
        hitView.GetComponent<HitView>().OnUnHit();
    }

    GameObject GetHitView()
    {
        return _hitView;
    }
}
