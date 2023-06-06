using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProceduralJail : MonoBehaviour
{
    [Range(0, 1)]
    public float treshHold = 0.5f;
    
    int seed = 0;
    public Light light = new Light();
    public Transform gridParent;
    public List<GameObject> grid = new List<GameObject>();

    [Header("Deco Elements")]
    public List<GameObject> deco = new List<GameObject>();

    [Header("Significant Elements")]
    public List<GameObject> significantElements = new List<GameObject>();

    public GameObject exit;

    [SerializeField]
    private float highestValue = 0f;
    [SerializeField]
    private float lowestValue = 100f;
    // Start is called before the first frame update
    void Start()
    {
        //foreach element in the grid list (which is empty) add a child of gridParent
        foreach (Transform child in gridParent)
        {
            grid.Add(child.gameObject);
            child.GetComponent<HeatUnit>().distanceToExit = DistanceToExit(child.position);
            highestValue = Mathf.Max(highestValue, child.GetComponent<HeatUnit>().distanceToExit);
            lowestValue = Mathf.Min(lowestValue, child.GetComponent<HeatUnit>().distanceToExit);
        }
        //randomly set seed to either 1 or -1
        seed = Random.Range(0, 2) * 2 - 1;
        HeatMap();
        AutoGenerate(seed);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AutoGenerate(int _seed)
    {
        switch (_seed)
        {
            case 1:
                //here we'll instantate the prefab with the good karma decision
                break;

            case -1:
                //here we'll instantate the prefab with the bad karma decision
                light.color = Color.red;
                break;
                
            default:

                break;
        }
    }

    
    public void HeatMap()
    {
        foreach (Transform child in gridParent)
        {
            child.GetComponent<HeatUnit>().heatMapValue = Map(child.GetComponent<HeatUnit>().distanceToExit, lowestValue, highestValue, 0, 1);
            InstantiateFurniture(child);
        }
    }

    public void InstantiateFurniture(Transform child)
    {
        if (child.GetComponent<HeatUnit>().heatMapValue > treshHold)
        {
            Instantiate(deco[Random.Range(0, deco.Count)], child.position, Quaternion.identity);
        }
        
        if (child.GetComponent<HeatUnit>().distanceToExit == lowestValue)
        {
            Instantiate(significantElements[Random.Range(0, significantElements.Count)], child.position, Quaternion.identity);
        }
    }
    public float DistanceToExit(Vector3 _pos)
    {
        //given a certain position in the world, return the distance to the exit
        return Vector3.Distance(_pos, exit.transform.position);
    }

    //given a value a minValueIn a minValue max a outValue min and a outValue max create a Map function
    public float Map(float _a, float _minValueIn, float _maxValueIn, float _minValueOut, float _maxValueOut)
    {
        //return the value mapped from the input range to the output range
        return (_a - _minValueIn) / (_maxValueIn - _minValueIn) * (_maxValueOut - _minValueOut) + _minValueOut;
    }
}
