using UnityEngine;
using System.Collections;

public class DoorPrefab : MonoBehaviour {
	public Transform[] spawnPoints;


	
	void findNewLocation(){
		int numberOfSpawnPoints = spawnPoints.Length;
		int ranNum = Random.Range(0,numberOfSpawnPoints);
		transform.parent = spawnPoints[ranNum];
		transform.localPosition =  Vector3.zero;
		transform.localRotation = Quaternion.identity;
		Debug.Log(ranNum);
	}
}
