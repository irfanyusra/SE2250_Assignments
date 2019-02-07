using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObjectSpawnerScript : MonoBehaviour
{
    public GameObject pickupObjectPrefabVar;
    public List <GameObject> gameObjectList;
     
     public int numOfObjectsOnTheScene;
     int numPickupObjects = 0;
     float radius = 9f;
    

    // Start is called before the first frame update
    void Start()
    {
        gameObjectList=new List<GameObject>();
      while (numPickupObjects<= numOfObjectsOnTheScene){
          int objectScore =  Random.Range(1, 4);
        if(objectScore == 1)
            addObjects (objectScore, Color.green);  
        else if (objectScore == 2)
            addObjects (objectScore, Color.red); 
        else if (objectScore==3) 
            addObjects (objectScore, Color.yellow); 
        numPickupObjects++;
       }
    }

    
    void addObjects (int objectScore, Color color){

        GameObject gameObject = Instantiate <GameObject> (pickupObjectPrefabVar);
        gameObject.name = "PickupObj"+ numPickupObjects +" - " + objectScore;
        gameObject.GetComponent<Renderer>().material.color = color;
        float angle = numPickupObjects * Mathf.PI*2f / numOfObjectsOnTheScene;
        Vector3 newPos = new Vector3(Mathf.Cos(angle)*radius, 1, Mathf.Sin(angle)*radius);
        gameObject.tag="PickUp"+objectScore.ToString();
        gameObject.transform.position = newPos;//new Vector3 (xpos,1.5f,zpos);//Random.insideUnitSphere;
        gameObjectList.Add(gameObject);

    }


    
}
