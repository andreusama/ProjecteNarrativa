using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karmaTracker : MonoBehaviour
{
    public float karma = 50;

    void Start()
    {

    }

    public void AddKarma(float value)
    {
        karma += value;
    }
}
