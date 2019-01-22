using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRightClickMouseBehaviourScript : MonoBehaviour
{
    Vector3 originalPos;
    Quaternion originalRotation;
    
 

    // Start is called before the first frame update
    void Start()
    {
        originalPos = this.gameObject.transform.position;
        originalRotation = this.gameObject.transform.rotation;
 
    }

    // Update is called once per frame
    void Update()
    {
      }
    
  void OnMouseOver () { //hover on an object
    if(Input.GetMouseButtonDown(1)){//right click 
         Reset();
    }
}
  void Reset() //reset some components of the object
  {
          this.gameObject.transform.position = originalPos;
          this.gameObject.transform.rotation = originalRotation;
        
  }
}

