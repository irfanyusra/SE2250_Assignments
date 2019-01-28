using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRightClickMouseBehaviourScript : MonoBehaviour
{    Vector3 originalPos; //original position of the object
    
    // Start is called before the first frame update
    void Start()
    {
      originalPos = this.gameObject.transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
    }
    
  void OnMouseOver () //hover on an object
  { 
    if(Input.GetMouseButtonDown(1)) //right click 
      ResetPostion();
  }

void ResetPostion(){
    this.gameObject.transform.position = originalPos; //changes the postion to the original position 
  }

}

