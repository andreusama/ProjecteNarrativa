using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    //create two transforms with name of spawn points
    public Transform spawnPointMentor;
    public Transform spawnPointScaping;

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckQuest()
    {
        Debug.Log("New advancing!");
    }
}
