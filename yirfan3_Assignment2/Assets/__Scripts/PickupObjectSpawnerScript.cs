using UnityEngine;

public class PickupObjectSpawnerScript : MonoBehaviour
{
	public GameObject pickupObjectPrefabVar;
	public int numOfObjectsOnTheScene;
	private int numPickupObjects = 0;
	private float radius = 9f;

	// Start is called before the first frame update
	void Start()
	{
		while (numPickupObjects < numOfObjectsOnTheScene)
		{
			int objectScore = Random.Range(1, 4);
			if (objectScore == 1)
				AddObjects(objectScore, Color.green);
			else if (objectScore == 2)
				AddObjects(objectScore, Color.red);
			else if (objectScore == 3)
				AddObjects(objectScore, Color.yellow);
			numPickupObjects++;
		}
	}

	void AddObjects(int objectScore, Color color)
	{
		GameObject go = Instantiate<GameObject>(pickupObjectPrefabVar);
		go.name = "PickupObj" + numPickupObjects + " - " + objectScore;
		go.GetComponent<Renderer>().material.color = color;
		go.GetComponent<PickupScore>().ScorePickup = objectScore;
		go.tag = "PickUp";

		//for the position of the objects
		float angle = numPickupObjects * Mathf.PI * 2f / numOfObjectsOnTheScene;
		Vector3 newPos = new Vector3(Mathf.Cos(angle) * radius, 1, Mathf.Sin(angle) * radius);
		go.transform.position = newPos;

	}
}
