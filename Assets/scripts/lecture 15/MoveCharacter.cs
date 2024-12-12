using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace lecture15
{
    public class MoveCharacter : MonoBehaviour
    {
        public Transform[] points;
        public float speed = 0.1f;

        private int currentPointIndex = 0;
        public Transform cityScale;
        void Update()
        {
            if (cityScale.localScale == new Vector3(1, 1, 1))
            {


                if (points.Length > 0)
                {

                    Transform targetPoint = points[currentPointIndex];


                    transform.position = Vector3.MoveTowards(transform.position, targetPoint.position, speed * Time.deltaTime);
                    Debug.Log($"Current Position: {transform.position}");
                    Debug.Log($"Target Position: {targetPoint.position}");

                    if (Vector3.Distance(transform.position, targetPoint.position) < 0.05f)
                    {

                        currentPointIndex = (currentPointIndex + 1) % points.Length;
                        Debug.Log($"Moving to Next Point: {currentPointIndex}");
                    }
                }
            }
        }
    }
}