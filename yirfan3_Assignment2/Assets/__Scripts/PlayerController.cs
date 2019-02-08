using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
	public float speed;
	public Text scoreText;
	private int score;

	// Start is called before the first frame update
	void Start()
	{
		score = 0;
		SetScoreText();
	}


	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
		GetComponent<Rigidbody>().AddForce(movement * speed);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("PickUp"))
		{
			//score += other.GetComponent<PickupScore>().ScorePickup;
			GameObject thePlayer = GameObject.Find(other.name);
			PickupScore playerScript = thePlayer.GetComponent<PickupScore>();
			score += playerScript.ScorePickup;

			other.gameObject.SetActive(false);
		}
		scoreText.text = "Score: " + score;
	}

	void SetScoreText()
	{
		scoreText.text = "Score: " + score;
	}
}
