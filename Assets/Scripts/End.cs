using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class End : MonoBehaviour
{
    public GameObject Score;
    public int score = randomNumber.instance.scoreValue;
    private void Update()
    {
        Score.GetComponent<Text>().text = "Score: " + score;
    }
}
