using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class funnysentence : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] funWords = { "cat", "dog" , "car" , "pizza" , "hat" , "fish","tree","monkey","ball","bird" };
        string funSent=" " ;
      int enter=0;
        while (enter<7)
        {
         string funword = funWords[Random.Range(0,10)] ;
        funSent += funword += " " ; 
        
           enter++;
        }
         Debug.Log(funSent);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
