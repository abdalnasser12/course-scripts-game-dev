using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace lecture15
{


    public class RotationCityAndBook : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(new Vector3(0, transform.rotation.y + 1, 0), Space.Self);
            }
            else if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(new Vector3(0, transform.rotation.y - 1, 0), Space.Self);
            }
        }
    }
}
