using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject LAr, RAr, PersonStandUp;
    EyeContact _eyeContact;
    //AvoidDistraction _avoidDistraction;
    //TimeSet _timeSet;
    //Record _record; 
    //Question _question;

    //public UIManager UIManager;
    private void Awake()
    {
        _eyeContact = this.GetComponent<EyeContact>();
        //_avoidDistraction = this.GetComponent<AvoidDistraction>();
        //_timeSet = this.GetComponent<TimeSet>();
        //UIManager = this.GetComponent<UIManager>();
        //_record = this.GetComponent<Record>();
        //_question = this.GetComponent<Question>();

        InvokeRepeating("F_EyeContact", 5, 5f);
        InvokeRepeating("F_AvoidDistraction", 0, 0.2f);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            PersonStandUp.GetComponent<Animator>().SetBool("willStand", true);
        }
    }
    #region FunctionShowcase
    public void F_EyeContact()
    {
        int dir = _eyeContact.GetComponent<EyeContact>().ECTracking();
        print(dir);
        if (dir == 0)
        {
            LAr.SetActive(true);
            RAr.SetActive(false);
        }
        else
        {
            LAr.SetActive(false);
            RAr.SetActive(true);
        }
    }
    public void F_AvoidDistraction()
    {
        //print(_avoidDistraction.attractMicVolume);
    }
    public void F_SetTime(float maxTime)
    {
        //_timeSet.curTime = 0;
        //_timeSet.maxTime = maxTime;
    }
    public void F_Record(string fileName)
    {
        //_record.RecordIt(fileName);
    }
    public void F_Question()
    {
        //From UI 
        string[] inQ = new string[10];

        //_question.Input(inQ);
        
    }
    #endregion

    #region UIContact
    #endregion
}
