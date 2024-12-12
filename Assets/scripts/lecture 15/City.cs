using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
namespace lecture15
{
    public class City : MonoBehaviour
    {




        float minScale = 0f;
        float maxScale = 1f;

        float scaleFactor = 1f;



        void Start()
        {
            scaleFactor = minScale;

        }
        void Update()
        {
            if (Input.GetKey(KeyCode.Mouse0))
            {

                scaleFactor += Time.deltaTime / 35;
                float positionX = Mathf.Lerp(transform.position.x, 1, Time.deltaTime / 12);
                Mathf.Clamp(positionX, transform.position.x, 1f);
                transform.position = new Vector3(positionX, 0, 0);

            }

            else if (Input.GetKey(KeyCode.Mouse1))
            {

                scaleFactor -= Time.deltaTime / 5;
                float positionX = Mathf.Lerp(transform.position.x, 0, Time.deltaTime);
                Mathf.Clamp(positionX, 0f, 1f);
                transform.position = new Vector3(positionX, 0, 0);

            }
            scaleFactor = Mathf.Clamp(scaleFactor, minScale, maxScale);

            transform.localScale = Vector3.one * scaleFactor;


        }
    }

}