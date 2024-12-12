using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace lecture15
{
    public class Cameramoves : MonoBehaviour
    {
        public Transform cityscale;
        //UnityEditor.TransformWorldPlacementJSON:{"position":{"x":0.5578684210777283,"y":0.9462895393371582,"z":-1.5596669912338257},"rotation":{"x":0.12006843090057373,"y":-0.0067145503126084808,"z":0.0029889435973018409,"w":0.9927384257316589},"scale":{"x":1.0,"y":1.0,"z":1.0}}
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (cityscale.localScale == new Vector3(1, 1, 1))
            {
                transform.position = new Vector3(0.5578684210777283f, 0.574f, -2.5596669912338257f);
                transform.rotation = Quaternion.Euler(new Vector3(0.12006843090057373f, -0.0067145503126084808f, 0.0029889435973018409f));
            }
        }
    }
}