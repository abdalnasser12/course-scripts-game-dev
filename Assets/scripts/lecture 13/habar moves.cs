using System.IO.Compression;
using JetBrains.Annotations;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UIElements;


namespace lecture13
{


    public class habarmoves : MonoBehaviour
    {

        float i;

        public float z = 0.1f;
        float f = 1.0f;
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            i = i + 0.01f;
            z = z + 0.00001f;
            // f=f+1.0f;
            // float p = Mathf.PingPong(f, 2.0f);
            transform.position = new Vector3(transform.position.x, transform.position.y + z, transform.position.z);
            //transform.localScale = new Vector3(0, p, 0);
            transform.rotation = quaternion.Euler(new Vector3(0, i, 0));
        }
    }
}