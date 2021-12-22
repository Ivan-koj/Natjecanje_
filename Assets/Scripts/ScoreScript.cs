using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public static ScoreScript instance;
    public static int scoreValue = 0;
    public Text score;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score = GetComponent<Text>();
        score.text = "Score: " + scoreValue;
    }

    public void Answer()
    {

        scoreValue += 1;
        Debug.Log("Correct");    
        
    }
}
