using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class BoxRightClickBehaviourScript : MonoBehaviour
{
  
  public GameObject box;
  float rotateX = 5f;
  float rotateY = -3f;
  float rotateZ = 3f;
   
 // Start is called before the first frame update
  void Start()
  {
  }

  // Update is called once per frame
  public void Update()
  {          
  }

//hover on an object
  void OnMouseOver () 
  { 
  if(Input.GetMouseButtonDown(0)||Input.GetMouseButtonDown(1)||Input.GetMouseButtonDown(2))//right or left click  
      box.transform.Rotate(rotateX,rotateY,rotateZ);
  }
}
