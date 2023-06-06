using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    public Slider slider;

    private static SliderController sliderInstance;

    public GameObject karmaTracker;

    public static SliderController MySliderInstance
    {
        get
        {
            if (sliderInstance == null)
            {
                sliderInstance = FindObjectOfType<SliderController>();
            }
            return sliderInstance;
        }


    }
    // Start is called before the first frame update
    void Start()
    {
        //LevelTraveler.MyTravelInstance.stats.Karma = slider.value;
        karmaTracker = GameObject.Find("KarmaTracker");
        SetSlider(karmaTracker.GetComponent<karmaTracker>().karma);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateSlider(float value)
    {
        slider.value += value;
        karmaTracker.GetComponent<karmaTracker>().AddKarma(value);
    }

    private void SetSlider(float value)
    {
        slider.value = value;
    }
}
