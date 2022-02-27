using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Unity.Mathematics.math;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public GameObject la;
    public GameObject la1;
    public GameObject la3;
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
            la.SetActive(true);
            la1.SetActive(false);
            
        }
        else
        {
            la1.SetActive(true);
            la.SetActive(false);
            
        }
        
    }

    public void Quit()
    {
        Time.timeScale = 0;
        la3.SetActive(true);
        
    }
    public void Continue()
    {
        Time.timeScale = 1f;
        la3.SetActive(false);
        
    }

    

}
