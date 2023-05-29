using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTraveler : MonoBehaviour
{
    public enum KarmStates
    {
        IDLE, 
        ADD,
        SUBSTRACT
    }

    public KarmStates karmaStates;
    
    public Stats stats;
    private static LevelTraveler travelInstance;

    public static LevelTraveler MyTravelInstance
    {
        get
        {
            if (travelInstance == null)
            {
                travelInstance = FindObjectOfType<LevelTraveler>();
            }
            return travelInstance;
        }


    }

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        


        Debug.Log("Loading from awake");

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            stats.Karma += 10;
        }
        if (Input.GetKeyDown(KeyCode.F2))
        {
            stats.Karma -= 10;
        }
    }

 
    public void UpdateKarma()
    {

    }
    
}
