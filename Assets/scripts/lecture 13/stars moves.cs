using UnityEngine;
namespace lecture13
{


    public class starsmoves : MonoBehaviour
    {
        public float z = 0.1f;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            z = z + 0.00001f;
            transform.position = new Vector3(transform.position.x, transform.position.y + z, transform.position.z);
        }
    }
}