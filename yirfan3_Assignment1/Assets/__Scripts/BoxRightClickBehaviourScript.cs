using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class BoxRightClickBehaviourScript : MonoBehaviour
{
  
  public GameObject box;
  public Quaternion rot; 
  float rotateX = 5;
  float rotateY = -3;
  float rotateZ = 3;
   
 // Start is called before the first frame update
  void Start()
  {
  }

  // Update is called once per frame
  public void Update()
  {          
  }

  void OnMouseOver () //hover on an object
  { 
  if(Input.GetMouseButtonDown(1)||Input.GetMouseButtonDown(2))//right or left click  
      box.transform.Rotate(rotateX,rotateY,rotateZ);
  }
}
