using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Villian : MonoBehaviour
{        
    string name = "Villian";
    int age = 40; 
    float height = 6.4f;
    bool nice = false;
  
  
    // Start is called before the first frame update
    void Start()
    {
       Debug.Log ("Second Character: " + name);
       Debug.Log ("Age: " + age);
       Debug.Log ("Height: " + height);
       Debug.Log ("Nice: " + nice);
    }


}
