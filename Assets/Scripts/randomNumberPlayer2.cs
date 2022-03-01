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

public class randomNumberPlayer2 : MonoBehaviour
{
    public KeyCode sel;
    public bool one;
    public bool two;
    public bool three;
    public bool four;
    public bool five;
    public bool six;
    public bool seven;
    public bool eight;
    public bool nine;
    public bool zero;
    public bool minus;
    public bool clear;
    public bool check;
    public bool quit;
    public LayerMask whatIs1;
    public LayerMask whatIs2;
    public LayerMask whatIs3;
    public LayerMask whatIs4;
    public LayerMask whatIs5;
    public LayerMask whatIs6;
    public LayerMask whatIs7;
    public LayerMask whatIs8;
    public LayerMask whatIs9;
    public LayerMask whatIs0;
    public LayerMask whatIsMinus;
    public LayerMask whatIsClear;
    public LayerMask whatIsCheck;
    public LayerMask whatIsQuit;
    public Transform groundCheckPoint;
    public float In;
    public string In1;
    public InputField InputField;
    public static randomNumberPlayer2 instance;
    public int scoreValue = 0;
    public GameObject Score;
    public GameObject FinalScore;
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
        one = Physics2D.OverlapCircle(groundCheckPoint.position, 10f, whatIs1);
        if (one)
        {
            if(Input.GetKeyDown(sel))
            {
                One();
            }
        }
        two = Physics2D.OverlapCircle(groundCheckPoint.position, 10f, whatIs2);
        if (two)
        {
            if(Input.GetKeyDown(sel))
            {
                Two();
            }
        }
        three = Physics2D.OverlapCircle(groundCheckPoint.position, 10f, whatIs3);
        if (three)
        {
            if(Input.GetKeyDown(sel))
            {
                Three();
            }
        }
        four = Physics2D.OverlapCircle(groundCheckPoint.position, 10f, whatIs4);
        if (four)
        {
            if(Input.GetKeyDown(sel))
            {
                Four();
            }
        }
        five = Physics2D.OverlapCircle(groundCheckPoint.position, 10f, whatIs5);
        if (five)
        {
            if(Input.GetKeyDown(sel))
            {
                Five();
            }
        }
        six = Physics2D.OverlapCircle(groundCheckPoint.position, 10f, whatIs6);
        if (six)
        {
            if(Input.GetKeyDown(sel))
            { 
                Six();
            }
        }
        seven = Physics2D.OverlapCircle(groundCheckPoint.position, 10f, whatIs7);
        if (seven)
        {
            if(Input.GetKeyDown(sel))
            {
                Seven();
            }
        }
        eight = Physics2D.OverlapCircle(groundCheckPoint.position, 10f, whatIs8);
        if (eight)
        {
            if(Input.GetKeyDown(sel))
            {
                Eight();
            }
        }
        nine = Physics2D.OverlapCircle(groundCheckPoint.position, 10f, whatIs9);
        if (nine)
        {
            if(Input.GetKeyDown(sel))
            {
                Nine();
            }
        }
        minus = Physics2D.OverlapCircle(groundCheckPoint.position, 10f, whatIsMinus);
        if (minus)
        {
            if(Input.GetKeyDown(sel))
            {
                Minus();
            }
        }
        zero = Physics2D.OverlapCircle(groundCheckPoint.position, 10f, whatIs0);
        if (zero)
        {
            if(Input.GetKeyDown(sel))
            {
                Zero();
            }
        }
        clear = Physics2D.OverlapCircle(groundCheckPoint.position, 10f, whatIsClear);
        if (clear)
        {
            if(Input.GetKeyDown(sel))
            {
                Clear();
            }
        }
        check = Physics2D.OverlapCircle(groundCheckPoint.position, 10f, whatIsCheck);
        if (check)
        {
            if(Input.GetKeyDown(sel))
            {
                RandomNum();
                In1 = "";
                InputField.text =In1;
                In = 0;
            }
        }
        quit = Physics2D.OverlapCircle(groundCheckPoint.position, 10f, whatIsQuit);
        if (quit)
        {
            if(Input.GetKeyDown(sel))
            { 
                SceneManager.LoadScene("MainMenu");
            }
        }
        FinalScore.GetComponent<Text>().text = "Player 2 had: " + scoreValue;
        Score.GetComponent<Text>().text = "Player 2 have: " + scoreValue;
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
            if (answerString == In1)
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
            if (answerString == In1)
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
            if (answerString == In1)
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
            Num22=Num1=round(Random.Range(1.0f, 2.0f));
        }
        
        
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
        Debug.Log(scoreValue);
        
    }

    public void Answer()
    {
        scoreValue += 1;
    }
//
    public void One()
    {
        if (In==0 )
        {
            In1 = "1";
            InputField.text = In1;
            In = 1;
        }
        else if(In==1)
        {
            In1 = In1 + "1";
            InputField.text =In1;
            In = 2;
        }
        else
        {
            In1 = In1 + "1";
            InputField.text =In1;
        }
        
    }
    public void Two()
    {
        if (In==0 )
        {
            In1 = "2";
            InputField.text = In1;
            In = 1;
        }
        else if(In==1)
        {
            In1 = In1 + "2";
            InputField.text =In1;
            In = 2;
        }
        else
        {
            In1 = In1 + "2";
            InputField.text =In1;
        }
        
    }
    public void Three()
    {
        if (In==0 )
        {
            In1 = "3";
            InputField.text = In1;
            In = 1;
        }
        else if(In==1)
        {
            In1 = In1 + "3";
            InputField.text =In1;
            In = 2;
        }
        else
        {
            In1 = In1 + "3";
            InputField.text =In1;
        }
        
    }
    public void Four()
    {
        if (In==0 )
        {
            In1 = "4";
            InputField.text = In1;
            In = 1;
        }
        else if(In==1)
        {
            In1 = In1 + "4";
            InputField.text =In1;
            In = 2;
        }
        else
        {
            In1 = In1 + "4";
            InputField.text =In1;
        }
        
    }
    public void Five()
    {
        if (In==0 )
        {
            In1 = "5";
            InputField.text = In1;
            In = 1;
        }
        else if(In==1)
        {
            In1 = In1 + "5";
            InputField.text =In1;
            In = 2;
        }
        else
        {
            In1 = In1 + "5";
            InputField.text =In1;
        }
        
    }
    public void Six()
    {
        if (In==0 )
        {
            In1 = "6";
            InputField.text = In1;
            In = 1;
        }
        else if(In==1)
        {
            In1 = In1 + "6";
            InputField.text =In1;
            In = 2;
        }
        else
        {
            In1 = In1 + "6";
            InputField.text =In1;
        }
        
    }
    public void Seven()
    {
        if (In==0 )
        {
            In1 = "7";
            InputField.text = In1;
            In = 1;
        }
        else if(In==1)
        {
            In1 = In1 + "7";
            InputField.text =In1;
            In = 2;
        }
        else
        {
            In1 = In1 + "7";
            InputField.text =In1;
        }
        
    }
    public void Eight()
    {
        if (In==0 )
        {
            In1 = "8";
            InputField.text = In1;
            In = 1;
        }
        else if(In==1)
        {
            In1 = In1 + "8";
            InputField.text =In1;
            In = 2;
        }
        else
        {
            In1 = In1 + "8";
            InputField.text =In1;
        }
        
    }
    public void Nine()
    {
        if (In==0 )
        {
            In1 = "9";
            InputField.text = In1;
            In = 1;
        }
        else if(In==1)
        {
            In1 = In1 + "9";
            InputField.text =In1;
            In = 2;
        }
        else
        {
            In1 = In1 + "9";
            InputField.text =In1;
        }
        
    }
    public void Zero()
    {
        if (In==0 )
        {
            In1 = "0";
            InputField.text = In1;
            In = 1;
        }
        else if(In==1)
        {
            In1 = In1 + "0";
            InputField.text =In1;
            In = 2;
        }
        else
        {
            In1 = In1 + "0";
            InputField.text =In1;
        }
        
    }
    public void Minus()
    {
        if (In==0 )
        {
            In1 = "-";
            InputField.text = In1;
            In = 1;
        }
        else if(In==1)
        {
            In1 = In1 + "-";
            InputField.text =In1;
            In = 2;
        }
        else
        {
            In1 = In1 + "-";
            InputField.text =In1;
        }
        
    }

    public void Clear()
    {
        In1 = "";
        InputField.text =In1;
        In = 0;
    }

    public void Quit()
    {
        MainMenu1.instance.Back();
    }
}

