using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class funnysen2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] funWords = { "cat", "dog" , "car" , "pizza" , "hat" , "fish","tree","monkey","ball","bird" };
        int enter=0;
        while (enter<1)
        {
            string funword = funWords[Random.Range(0,10)];
            string funword1 = funWords[Random.Range(0,10)];
            string funword2 = funWords[Random.Range(0,10)];
            string funword3 = funWords[Random.Range(0,10)];
            string funword4 = funWords[Random.Range(0,10)];
            string funword5 = funWords[Random.Range(0,10)];
            string funword6 = funWords[Random.Range(0,10)];
        
Debug.Log(funword+" "+funword1+" "+ funword2 + " " + funword3+ " " + funword4 + " "+ funword5+"" + funword6);
            
            enter++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
