using UnityEngine;
using System.Collections;

public class doorRandomize : MonoBehaviour {
    public Transform testDoor;
    
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

	}

    void OnBecameInvisible()
    {
        
        Instantiate(testDoor, new Vector3(Random.Range(-2f, 2f), Random.Range(-2f, 2f), Random.Range(-2f, 2f)), Quaternion.identity);
        Destroy(gameObject);
    }
}