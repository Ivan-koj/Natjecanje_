using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IField : MonoBehaviour
{
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
        input = s;
    }

    public void Check()
    {
        Debug.Log(input);
        randomNumber.instance.randomNum();
        randomNumber.instance.Zbrajanje();
        randomNumber.instance.Jednakost();
    }
    
}
