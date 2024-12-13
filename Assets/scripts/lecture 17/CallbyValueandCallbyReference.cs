
using UnityEngine;
namespace lecture17
{


    public class CallbyValueandCallbyReference : MonoBehaviour
    {
        int numb1 = 1;
        int numb2 = 2;

        void Start()
        {

            Debug.Log(numb1);
            ByValue(numb1);
            Debug.Log(numb1);
            Debug.Log(numb2);
            ByReference(ref numb2);
            Debug.Log(numb2);
            ByOut(out numb1);
            Debug.Log(numb1);
            ByOut(out numb2);
            Debug.Log(numb2);




        }

        void ByValue(int number)
        {
            number += 10;
            Debug.Log(number);
        }
        void ByReference(ref int number)
        {
            number += 10;
            Debug.Log(number);

        }

        void ByOut(out int number)
        {
            number = 10;
            Debug.Log(number);
        }
    }
}