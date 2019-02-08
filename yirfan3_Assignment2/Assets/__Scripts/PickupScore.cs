using UnityEngine;

public class PickupScore : MonoBehaviour
{
	private int scorePickup = 0;
	public int ScorePickup
	{
		get
		{	
			return scorePickup;
		}
		set
		{
			scorePickup = value;
		}
	}
}
