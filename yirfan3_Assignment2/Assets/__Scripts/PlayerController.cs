using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
 public float speed;
 public Text scoreText;
 private Rigidbody rigidbody;


int score;
// Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent <Rigidbody>();
        score =0;
        SetScoreText();
     
    }

  
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        
        Vector3 movement = new Vector3 (moveHorizontal,0.0f,moveVertical);

        rigidbody.AddForce (movement*speed); 
    }

 void OnTriggerEnter(Collider other){
     if (other.gameObject.CompareTag("PickUp1")){
         other.gameObject.SetActive(false);
         score+=1;
     }
      if (other.gameObject.CompareTag("PickUp2")){
         other.gameObject.SetActive(false);
         score+=2;
     }
      if (other.gameObject.CompareTag("PickUp3")){
         other.gameObject.SetActive(false);
         score+=3;
     }
      scoreText.text= "Score: " + score ;  

 }
    
    void SetScoreText(){
        scoreText.text= "Score: " + score ;  
     }
}
