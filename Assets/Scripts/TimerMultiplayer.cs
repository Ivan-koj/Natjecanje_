using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Unity.Mathematics.math;
using UnityEngine.SceneManagement;

public class TimerMultiplayer : MonoBehaviour
{
    public KeyCode esc;
    public GameObject la;
    public GameObject la1;
    public GameObject la3;
    public static TimerMultiplayer instance;
    public float timeRemaining;
    Text timer;

    void Start()
    {   
        Cursor.visible = false;
        timer = GetComponent<Text>();
    }

    void Update()
    {
        timer.text = "Time left: " + round(timeRemaining) ;
        if (Input.GetKeyDown(esc))
        {
            Quit();
        }
        if (timeRemaining > 0)
        {
            
            timeRemaining -= Time.deltaTime;
            la.SetActive(true);
            la1.SetActive(false);
            

        }
        else
        {
            Cursor.visible = true;
            la1.SetActive(true);
            la.SetActive(false);
        }
        
    }

    public void Quit()
    {
        Cursor.visible = true;
        Time.timeScale = 0;
        la3.SetActive(true);
        
    }
    public void Continue()
    {
        Cursor.visible = false;
        Time.timeScale = 1f;
        la3.SetActive(false);
        
    }

    

}
