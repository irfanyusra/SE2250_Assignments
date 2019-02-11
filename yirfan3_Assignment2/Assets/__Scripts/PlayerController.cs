using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
	public float speed;
	public Text scoreText;
	private int _score;

	// Start is called before the first frame update
	void Start()
	{
		_score = 0;
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
			_score += other.gameObject.GetComponent<PickupScore>().ScorePickup;
			Destroy(other.gameObject);
		}
		SetScoreText();
	}

	void SetScoreText()
	{
		scoreText.text = "Score: " + _score;
	}
}
