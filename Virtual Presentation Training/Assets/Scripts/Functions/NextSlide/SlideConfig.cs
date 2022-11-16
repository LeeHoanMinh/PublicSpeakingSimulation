using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideConfig : MonoBehaviour
{
    public int maxSlide, curSlide;
    public GameObject slides;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            //NextSlide
            NextSlide();
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //PrevSlide
            PrevSlide();
        }
    }
    public void NextSlide()
    {
        if (curSlide < maxSlide)
        {
            slides.transform.GetChild(curSlide).gameObject.SetActive(false);
            curSlide++;
            slides.transform.GetChild(curSlide).gameObject.SetActive(true);
        }
    }
    public void PrevSlide()
    {
        if (curSlide > 0)
        {
            slides.transform.GetChild(curSlide).gameObject.SetActive(false);
            curSlide--;
            slides.transform.GetChild(curSlide).gameObject.SetActive(true);
        }
    }
}
