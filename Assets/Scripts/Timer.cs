using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Unity.Mathematics.math;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public static Timer instance;
    public GameObject pauseScreen;
    public bool IsPause=false;
    public float timeRemaining;
    Text timer;

    void Start()
    {   
       
        timer = GetComponent<Text>();
    }

    void Update()
    {
        timer.text = "Time left: " + round(timeRemaining) ;
        if (timeRemaining > 0)
        {
            
            timeRemaining -= Time.deltaTime;
            IsPause = false;
        }
        else
        {
           
            timeRemaining = 0;
            Time.timeScale = 0f;
            IsPause = true;
            SceneManager.LoadScene("end");
        }
        
    }

    

}
