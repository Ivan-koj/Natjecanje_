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
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   

    public void ReadStringInput(string s)
    {
        
        input =s;
        
        
    }

    public void Check()
    {
        Debug.Log(input);
        
    }
    
}
