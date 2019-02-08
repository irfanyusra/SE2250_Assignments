using System.Collections;
using System.Collections.Generic;
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
		//gameObjectList = new List<GameObject>();
		while (numPickupObjects < numOfObjectsOnTheScene)
		{
			int objectScore = Random.Range(1, 4);
			if (objectScore == 1)
				addObjects(objectScore, Color.green);
			else if (objectScore == 2)
				addObjects(objectScore, Color.red);
			else if (objectScore == 3)
				addObjects(objectScore, Color.yellow);
			numPickupObjects++;
		}
	}


	void addObjects(int objectScore, Color color)
	{

		GameObject go = Instantiate<GameObject>(pickupObjectPrefabVar);
		go.name = "PickupObj" + numPickupObjects + " - " + objectScore;
		go.GetComponent<Renderer>().material.color = color;

		GameObject thePlayer = GameObject.Find("PickupObj" + numPickupObjects + " - " + objectScore);
		PickupScore playerScript = thePlayer.GetComponent<PickupScore>();
		playerScript.ScorePickup = objectScore;

		float angle = numPickupObjects * Mathf.PI * 2f / numOfObjectsOnTheScene;
		Vector3 newPos = new Vector3(Mathf.Cos(angle) * radius, 1, Mathf.Sin(angle) * radius);
	
		go.tag = "PickUp";

		go.transform.position = newPos;//new Vector3 (xpos,1.5f,zpos);//Random.insideUnitSphere;
		//gameObjectList.Add(gameObject);

	}



}
