using UnityEngine;
using System.Collections;

public class DoorPrefab : MonoBehaviour {
	public Transform[] spawnPoints;

	// Use this for initialization
	void Start () {
	
	}
	void Update(){
		if(Input.GetKeyDown(KeyCode.A)){
			findNewLocation();	
		}
	}
	void OnBecameInvisible(){
		Debug.Log("I am invisible");
		findNewLocation();
		
	}
	
	
	void findNewLocation(){
		int numberOfSpawnPoints = spawnPoints.Length;
		int ranNum = Random.Range(0,numberOfSpawnPoints);
		transform.parent = spawnPoints[ranNum];
		transform.localPosition =  Vector3.zero;
		transform.localRotation = Quaternion.identity;
		Debug.Log(ranNum);
		
	}
}
