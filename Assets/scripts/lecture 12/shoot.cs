using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;


public class shoot : MonoBehaviour
{
    public float deg = 0f;
    public float angleInc = 1f;
    int Score = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.F))
        {
            deg = deg + angleInc;
            transform.position += new Vector3(0, 0, -0.5f);
            transform.rotation = Quaternion.Euler(new Vector3(deg, 0, 0));
        }
        if (transform.position.z <= -4.0f)
        {
            Score++;
            Debug.Log("0 : " + Score);
            transform.position = new Vector3(-0.00257609994f, 0.231999993f, -0.00999999978f);


        }

    }
}