using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using Random = UnityEngine.Random;
using static Unity.Mathematics.math;
using System.Collections;
using TMPro;
using UnityEngine.SceneManagement;

public class randomNumber : MonoBehaviour
{
    public InputField Ip;
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
        Num11=Num2=round(Random.Range(1.0f, 10.0f)); 
        Num22=Num1=round(Random.Range(1.0f, 2.0f));
        PlusMinus=round(Random.Range(1.0f, 5.0f));
    }
    void Update()
    {
        Score1.GetComponent<Text>().text = "Score: " + scoreValue;
        Score.GetComponent<Text>().text = "Score: " + scoreValue;
        if (PlusMinus == 2)
        {
            Task.GetComponent<Text>().text = Num11 + " + " + Num22;
            answer = Num11 + Num22;
        }
        if (PlusMinus == 3)
        {
            Task.GetComponent<Text>().text = Num11 + " - " + Num22;
            answer = Num11 - Num22;
        }
        if (PlusMinus == 4)
        {
            Task.GetComponent<Text>().text = Num11 + " ✕ " + Num22;
            answer = Num11 * Num22;
        }
        if (PlusMinus == 5)
        {
            Task.GetComponent<Text>().text = Num11 + " : " + Num22;
            answer = Num11 / Num22;
            if (Num11 % Num22 > 0)
            {
                Num11=Num2=round(Random.Range(1.0f, 30.0f)); 
                Num22=Num1=round(Random.Range(1.0f, 15.0f));
            }
            else
            {
                answer = Num11 / Num22;
            }
        }
        if(PlusMinus==1)
        {
            Task.GetComponent<Text>().text = Num11 + " + " + Num22;
            answer = Num11 + Num22;
        }
        
    }
    public void RandomNum()
    {
        answerString = answer.ToString();
        if (PlusMinus == 4)
        {
            if (answerString == input)
            {
                scoreValue += 5;
            }
            else
            {
                Debug.Log("Incorrect");
            }
        }
        if (PlusMinus == 5)
        {
            if (answerString == input)
            {
                scoreValue += 5;
            }
            else
            {
                Debug.Log("Incorrect");
            }
        }
        else
        {
            if (answerString == input)
            {
                scoreValue += 1;
            }
            else
            {
                Debug.Log("Incorrect");
            }
        }
        PlusMinus=round(Random.Range(1.0f, 5.0f)); 
        
        if (PlusMinus == 1)
        {
            Num11=Num2=round(Random.Range(1.0f, 100.0f)); 
            Num22=Num1=round(Random.Range(1.0f, 100.0f));
        }
        if (PlusMinus == 2)
        {
            Num11=Num2=round(Random.Range(1.0f, 100.0f)); 
            Num22=Num1=round(Random.Range(1.0f, 100.0f));
        }
        if (PlusMinus == 3)
        {
            Num11=Num2=round(Random.Range(1.0f, 100.0f)); 
            Num22=Num1=round(Random.Range(1.0f, 100.0f));
        }
        if (PlusMinus == 4)
        {
            Num11=Num2=round(Random.Range(1.0f, 30.0f)); 
            Num22=Num1=round(Random.Range(1.0f, 10.0f));
        }
        if (PlusMinus == 5)
        {
            Num11=Num2=round(Random.Range(1.0f, 30.0f)); 
            Num22=Num1=round(Random.Range(1.0f, 10.0f));
        }
        
        
        Debug.Log(answerString);
        Debug.Log(input);
        input = "";
        Ip.text = input;
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

