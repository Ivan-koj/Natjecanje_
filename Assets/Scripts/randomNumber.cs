using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using Random = UnityEngine.Random;
using static Unity.Mathematics.math;


public class randomNumber : MonoBehaviour
{
    public static randomNumber instance;
    private float answer;
    public float Num2;
    public float Num1;
    Text RandomNumber;
 
    // Start is called before the first frame update
    void Start()
    {
        randomNum();
        RandomNumber = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        RandomNumber.text = Num1 + " + " + Num2;
    }

    public void randomNum()
    {
        Num2=round(Random.Range(1.0f, 100.0f));
        Num1=round(Random.Range(1.0f, 100.0f));
    }
    public void Zbrajanje()
    {
        answer = Num1 + Num2;
        Debug.Log(answer);
    }

    public void Jednakost()
    {
        if (answer == float.Parse(IField.instance.input))
        {
            ScoreScript.instance.Answer();
        }
    }
    
    
    
    
}

