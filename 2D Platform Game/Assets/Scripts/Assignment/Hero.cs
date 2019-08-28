using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    string name = "Hero"; 
    int age = 32;
    float height = 6.7f;
    bool friendly = true;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("First Character: " + name);
        Debug.Log("Age: " + age);
        Debug.Log("Height: " + height);
        Debug.Log("Friendly: " + friendly);
    }

    
}
