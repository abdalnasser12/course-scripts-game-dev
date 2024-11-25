
using Unity.Mathematics;
using UnityEngine;

namespace lecture13
{


    public class habarmoves : MonoBehaviour
    {

        float yrotation = 1.5f;

        public float ypoition = 0.000001f;

        //public GameObject[] stars;

        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

            yrotation = yrotation + 0.01f;
            ypoition = ypoition + 0.00001f;


            float yscal = Mathf.PingPong(Time.time, 1.0f);
            float zrotation = Mathf.Sin(Time.time) / Mathf.Rad2Deg + 0.7f;

            transform.position = new Vector3(transform.position.x, transform.position.y + ypoition, transform.position.z);
            transform.localScale = new Vector3(1, yscal, 1);
            transform.rotation = quaternion.Euler(new Vector3(0, yrotation, zrotation));
            // Transform yallowstar = transform.Find("yallow star");
            //  Transform redstar = transform.Find("red star");
            // Transform bluestar = transform.Find("blue star");
            // yallowstar.rotation = quaternion.Euler(0, -Time.time * 160.0f, 0);
            // redstar.rotation = quaternion.Euler(0, -Time.time * 160.0f, 0);
            //bluestar.rotation = quaternion.Euler(0, -Time.time * 160.0f, 0);




        }
    }
}
