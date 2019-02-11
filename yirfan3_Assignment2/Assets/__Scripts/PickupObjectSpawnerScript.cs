using UnityEngine;

public class PickupObjectSpawnerScript : MonoBehaviour
{
	public GameObject pickupObjectPrefabVar;
	public int numOfObjectsOnTheScene;
	private int _numPickupObjects = 1;
	private float _radius = 9f;
	private GameObject _go;

	// Start is called before the first frame update
	void Start()
	{
		while (_numPickupObjects <= numOfObjectsOnTheScene)
		{
			int objectScore = Random.Range(1, 4);
			if (objectScore == 1)
				AddObjects(objectScore, Color.green);
			else if (objectScore == 2)
				AddObjects(objectScore, Color.red);
			else if (objectScore == 3)
				AddObjects(objectScore, Color.yellow);
			_numPickupObjects++;
		}
	}

	void AddObjects(int objectScore, Color color)
	{
		//for the position of the objects to be in a circle 
		float _angle = _numPickupObjects * Mathf.PI * 2f / numOfObjectsOnTheScene;
		float _xpos = Mathf.Cos(_angle) * _radius;
		float _ypos = Mathf.Sin(_angle) * _radius;
		Vector3 pos = new Vector3( _xpos, 1.0f,_ypos);
	
		_go = Instantiate(pickupObjectPrefabVar, pos, pickupObjectPrefabVar.transform.rotation);
		_go.name = "PickupObj" + _numPickupObjects + " - " + objectScore;
		_go.GetComponent<Renderer>().material.color = color;
		_go.GetComponent<PickupScore>().ScorePickup = objectScore;
		

	}
}
