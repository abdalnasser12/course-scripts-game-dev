
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SocialPlatforms;

namespace lecture13
{


    public class starsmoves : MonoBehaviour
    {

        //public GameObject[] centerpoint;
        //public GameObject[] stars;
        //public GameObject[] habar;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {



            // transform.position = new Vector3(habar[0].transform.position.x, habar[0].transform.position.y, habar[0].transform.position.z);
            transform.localRotation = quaternion.Euler(new Vector3(0, Time.time * 20, 0));
            // stars[2].transform.rotation = quaternion.Euler(new Vector3(transform.rotation.x, transform.rotation.y + 10, transform.rotation.z));

        }
    }
}