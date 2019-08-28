using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stimpy : MonoBehaviour
{
    string name = "Stimpy";
    int age = 28;
    float height = 2.5f;
    bool funny = true;


    // Start is called before the first frame update
    void Start()
    {
    Debug.Log ("First Name: " + name);
    Debug.Log ("Age: " + age);
    Debug.Log ("Hieght: " + height);
    Debug.Log ("Funny: " + funny);
    }

    
}
