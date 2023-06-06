using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    public GameObject karmaTracker;
    public GameObject[] enemies;

    // Start is called before the first frame update
    void Start()
    {
        karmaTracker = GameObject.Find("KarmaTracker");

        float karma = karmaTracker.GetComponent<karmaTracker>().karma;

        if(karma < 50)
        {
            enemies[0].SetActive(true);
            enemies[1].SetActive(true);
        }

        if (karma < 30)
        {
            enemies[2].SetActive(true);
            enemies[3].SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
