using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using Random = UnityEngine.Random;
using static Unity.Mathematics.math;


public class randomNumber : MonoBehaviour
{
    public float Num22;
    public float Num11;
    public static randomNumber instance;
    private float answer;
    private string answer2;
    public float Num2;
    public float Num1; 
    public GameObject Task;
 
    // Start is called before the first frame update
    void Start()
    {
        Num11=Num2=round(Random.Range(1.0f, 100.0f)); 
        Num22=Num1=round(Random.Range(1.0f, 100.0f));
        answer = Num11 + Num22;
        Debug.Log(answer);
    }

    // Update is called once per frame
    void Update()
    {
        Task.GetComponent<Text>().text = Num11 + " + " + Num22;
    }
    public void randomNum()
    {
       
        Num11=Num2=round(Random.Range(1.0f, 100.0f)); 
        Num22=Num1=round(Random.Range(1.0f, 100.0f));
        
    }
    

    public void Calculate()
    {
        answer = Num11 + Num22;
        Debug.Log(answer);
        string answerString = answer.ToString();
        
        if(answerString == IField.instance.input)
        {
            ScoreScript.instance.Answer();
        }
        else
        {
            Debug.Log("Incorrect");
        }
        Debug.Log(answer);
    }
   
    
    
    
    
}

