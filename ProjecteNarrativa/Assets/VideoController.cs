using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    private double time = 0.0f;
    private double currentTime = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        time = videoPlayer.clip.length - 0.2;
        Debug.Log(time);
    }


    // Update is called once per frame
    void Update()
    {
        currentTime = videoPlayer.clockTime;
        Debug.Log(currentTime);
        if (currentTime >= time)
        {
            Debug.Log("video finished!");
            LoadSceneAfterVideo();
        }
    }

    public void LoadSceneAfterVideo()
    {
        //load the scene Loft3D with index 1
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
}
