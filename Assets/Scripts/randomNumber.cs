using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using Random = UnityEngine.Random;
using static Unity.Mathematics.math;
using System.Collections;

public class randomNumber : MonoBehaviour
{
    public static randomNumber instance;
    public int scoreValue = 0;
    public GameObject Score;
    public GameObject Score1;
    private string answerString;
    public float Num22;
    public float Num11;
    private float answer;
    private float PlusMinus;
    public float Num2;
    public float Num1; 
    public GameObject Task;
    public string input;
    

    void Start()
    {
        Num11=Num2=round(Random.Range(1.0f, 30.0f)); 
        Num22=Num1=round(Random.Range(1.0f, 30.0f));
        PlusMinus=round(Random.Range(1.0f, 4.0f));
    }
    void Update()
    {
        Score1.GetComponent<Text>().text = "Score: " + scoreValue;
        Score.GetComponent<Text>().text = "Score: " + scoreValue;
        if (PlusMinus == 1)
        {
            Task.GetComponent<Text>().text = Num11 + " + " + Num22;
            answer = Num11 + Num22;
        }
        if (PlusMinus == 2)
        {
            Task.GetComponent<Text>().text = Num11 + " - " + Num22;
            answer = Num11 - Num22;
        }
        else
        {
            Task.GetComponent<Text>().text = Num11 + " ✕ " + Num22;
            answer = Num11 * Num22;
        }
        
        
    }
    public void RandomNum()
    {
        
        answerString = answer.ToString();
        if (PlusMinus == 3)
        {
            if (answerString == input)
            {
                scoreValue += 10;
                Num11 = Num2 = round(Random.Range(1.0f, 30.0f));
                Num22 = Num1 = round(Random.Range(1.0f, 30.0f));
            }
            else
            {

                Debug.Log("Incorrect");
                Num11 = Num2 = round(Random.Range(1.0f, 30.0f));
                Num22 = Num1 = round(Random.Range(1.0f, 30.0f));
            }
        }
        else
        {
            if (answerString == input)
            {
                scoreValue += 1;
                Num11 = Num2 = round(Random.Range(1.0f, 30.0f));
                Num22 = Num1 = round(Random.Range(1.0f, 30.0f));
            }
            else
            {

                Debug.Log("Incorrect");
                Num11 = Num2 = round(Random.Range(1.0f, 30.0f));
                Num22 = Num1 = round(Random.Range(1.0f, 30.0f));
            }
        }

        PlusMinus=round(Random.Range(1.0f, 4.0f)); 
        Debug.Log(answerString);
        Debug.Log(input);
    }
    public void ReadStringInput(string s)
    {
        
        input = s;
        
        
    }

    public void Check()
    {
        Debug.Log(input);
        
    }

    public void Answer()
    {
        scoreValue += 1;
    }

    
    
        
    








}

