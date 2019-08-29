using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dax : MonoBehaviour
{
    string name = "Dax";
    int age = 21;
    float height = 5.10f;
    bool weapon = true;



    // Start is called before the first frame update
    void Start()
    {
     Debug.Log("First Name: " + name);
     Debug.Log("Age: " + age);
     Debug.Log("Height: " + height);
     Debug.Log("Weapon: " + weapon);
    }
}
