using UnityEngine;

public class PickupScore : MonoBehaviour
{
	private int _scorePickup = 0;
	public int ScorePickup
	{
		get
		{
			return _scorePickup;
		}
		set
		{
			_scorePickup = value;
		}
	}
}
