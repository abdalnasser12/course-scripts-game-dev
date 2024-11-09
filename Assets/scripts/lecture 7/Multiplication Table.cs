using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace lecture7
{


    public class NewBehaviourScript : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

            for (int i = 1; i <= 10; i++)
            {
                int result = Multiply(i, 5);
                Debug.Log(i + "* 5=" + result);
            }
        }
        int Multiply(int number, int number1)
        {
            int cross = number * number1;
            return cross;
        }
        // Update is called once per frame
        void Update()
        {

        }
    }
}