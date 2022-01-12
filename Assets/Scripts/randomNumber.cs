using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using Random = UnityEngine.Random;
using static Unity.Mathematics.math;


public class randomNumber : MonoBehaviour
{
    private string field = IField.instance.input;
    private string answerString;
    public float Num22;
    public float Num11;
    public static randomNumber instance;
    private float answer;
    private float PlusMinus;
    public float Num2;
    public float Num1; 
    public GameObject Task;
    
    void Start()
    {
        Num11=Num2=round(Random.Range(1.0f, 100.0f)); 
        Num22=Num1=round(Random.Range(1.0f, 100.0f));
        PlusMinus=round(Random.Range(1.0f, 2.0f)); 
        answer = Num11 + Num22;
        Debug.Log(answer);
    }
    void Update()
    {
        if (PlusMinus == 1)
        {
            Task.GetComponent<Text>().text = Num11 + " + " + Num22;
            answer = Num11 + Num22;
        }
        else
        {
            Task.GetComponent<Text>().text = Num11 + " - " + Num22;
            answer = Num11 - Num22;
        }
        
    }
    public void RandomNum()
    {
        
        answerString = answer.ToString();
        if(answerString == field)
        {
            ScoreScript.instance.scoreValue += 1;
            Num11=Num2=round(Random.Range(1.0f, 100.0f)); 
            Num22=Num1=round(Random.Range(1.0f, 100.0f));
        }
        else
        {
            Debug.Log("Incorrect");
            Num11=Num2=round(Random.Range(1.0f, 100.0f)); 
            Num22=Num1=round(Random.Range(1.0f, 100.0f));
        }
        PlusMinus=round(Random.Range(1.0f, 2.0f)); 

    }
    

    
   
    
    
    
    
}

