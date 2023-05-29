using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Stats", menuName = "Stats")]
public class Stats : ScriptableObject
{
    private float karma;
    public float Karma
    {
        set
        {
            karma = value;
            SliderController.MySliderInstance.UpdateSlider(karma);
        }
        get
        {
            return karma;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
