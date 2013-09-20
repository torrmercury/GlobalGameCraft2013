using UnityEngine;
using System.Collections;

public class baseObstacle : MonoBehaviour{

	//tell the ai to search for the player (defined later)
	public Transform target;
	//speed of the obstacle
	public int moveSpeed;
	//maximum distance before obstacle wakes up
	public int maxDistance;

	//caching the transform of the obstacle
	private Transform myTransform;

	void awake(){
		myTransform = transform;
	}

	void start(){
		//find the player and store it as gameobject "go"
		GameObject go = GameObject.FindGameObjectWithTag("Player");

		target = go.transform;

		maxDistance = 5;
	}

	void Update(){
		////checks to see if the distance between 2 points is greater than max distance
		if(Vector3.Distance(target.position, myTransform.position) > maxDistance){
		//move in the designated direction
			myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;
		}
	}
}