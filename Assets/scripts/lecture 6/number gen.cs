using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numbergen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         while (true)
        {
            int number = Random.Range(1, 21);
            if (number == 5)
            {
                Debug.Log("Continue");
                continue;
            }
            else if (number == 15)
            {
                Debug.Log("Break");
                break;

            }
            else
            {
                Debug.Log(number);
            }    
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
