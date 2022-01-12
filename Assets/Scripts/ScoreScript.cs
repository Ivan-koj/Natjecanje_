using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public static ScoreScript instance;
    public int scoreValue = 0;
    public Text Score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         
        Score = GetComponent<Text>();
        Score.text = "Score: " + scoreValue;
    }

    public void Answer()
    {
        
        scoreValue += 1;
    }
}
