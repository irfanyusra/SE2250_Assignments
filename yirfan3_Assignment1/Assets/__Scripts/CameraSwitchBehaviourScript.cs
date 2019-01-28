using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitchBehaviourScript : MonoBehaviour
{
    public Camera sideCamera; //Side Camera
    public Camera topCamera; //Top Camera

    // Start is called before the first frame update
    void Start()
    {
        sideCamera.enabled = true; //Enables Side Camera
        topCamera.enabled = false; //Disable Top Camera
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C)) //On pressing 'C' on the keyboard
        {
            //To switch cameras
            if (sideCamera.enabled) 
            {
                topCamera.enabled = true; //Enables Top Camera
                sideCamera.enabled = false; //Disable Side Camera
            }
            else
            {
                topCamera.enabled = false; //Disable Top Camera
                sideCamera.enabled = true; //Enables Side Camera
            }
        }
    }
}
