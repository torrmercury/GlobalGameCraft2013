using UnityEngine;
using System.Collections;

public class doorRandomize : MonoBehaviour {
    public Transform[] spawnPoints;
	public Transform datDoor;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

    void OnBecameInvisible()
    {
        int numberOfSpawnPoints = spawnPoints.Length;
		int ranNum = Random.Range(0,numberOfSpawnPoints);
		transform.parent = spawnPoints[ranNum];
		transform.localPosition =  Vector3.zero;
		transform.localRotation = Quaternion.identity;
		Debug.Log(ranNum);
        
    }
}