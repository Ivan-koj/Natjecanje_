using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using static Unity.Mathematics.math;
using Random = UnityEngine.Random;

public class IField : MonoBehaviour
{
    
    public float number;
    
    public static IField instance;
    public string input;
    
    public void ReadStringInput(string s)
    {
        
        input = s;
        
        
    }

    public void Check()
    {
        Debug.Log(input);
        
    }
    
}
