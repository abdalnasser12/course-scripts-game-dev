using UnityEngine;
namespace lecture18
{


    public class UnitySpecificScript : MonoBehaviour
    {
        private GameObject targetObject;
        private GameObject jokerObject;
        private Light lightObject;

        void OnEnable()
        {
            print("GameObject Enabled");
        }

        void OnDisable()
        {
            print("GameObject Disabled");
        }

        void Start()
        {
            print("Game started!");


            targetObject = GameObject.Find("TargetObject");
            if (targetObject != null)
            {
                print("Found object by name: " + targetObject.name);
            }
            else
            {
                print("No TargetObject found.");
            }


            jokerObject = GameObject.FindGameObjectWithTag("Joker");
            if (jokerObject != null)
            {
                print("Found object by tag: " + jokerObject.name);
            }
            else
            {
                print("No Joker object found.");
            }


            lightObject = GameObject.FindObjectOfType<Light>();
            if (lightObject != null)
            {
                print("Found object of type Light: " + lightObject.name);
            }
            else
            {
                print("No Light object found.");
            }
        }

        void Update()
        {

            if (Input.GetKeyDown(KeyCode.D))
            {
                if (targetObject != null && targetObject.activeSelf)
                {
                    targetObject.SetActive(false);
                    print("TargetObject deactivated!");
                }
            }
        }
    }

}