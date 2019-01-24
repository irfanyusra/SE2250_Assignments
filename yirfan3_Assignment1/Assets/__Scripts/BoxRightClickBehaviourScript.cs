using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxRightClickBehaviourScript : MonoBehaviour
{
  
     public GameObject box;
   
   float z;
   float y;
   float x;


 // Start is called before the first frame update
      void Start()
    {
      x=box.transform.rotation.z;
      z=box.transform.rotation.z;
      y=box.transform.rotation.y;
    }

  
    
    // Update is called once per frame
     public void Update()
     {      
        
     }
     void OnMouseOver () { //hover on an object
    if(Input.GetMouseButtonDown(1)){//right click 
        z+=5;
        y=-5;
        box.transform.rotation = Quaternion.Euler(new Vector3(x, y, z));
    }
     }
}
