
using System;
using UnityEngine;
namespace lecture15
{
    public class BookMoves : MonoBehaviour
    {


        public float openBookSpeed = 40;
        float bookAngle = -180;


        void Update()
        {
            if (Input.GetKey(KeyCode.Mouse1))
            {
                bookAngle -= Time.deltaTime * 50;
                RotateBookCover();
            }
            else if (Input.GetKey(KeyCode.Mouse0))
            {
                bookAngle += Time.deltaTime * openBookSpeed;
                RotateBookCover();
            }




        }

        public void RotateBookCover()
        {
            bookAngle = Mathf.Clamp(bookAngle, -180, 0);
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, -bookAngle));


        }





    }

}