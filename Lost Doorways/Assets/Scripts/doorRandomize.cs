using UnityEngine;
using System.Collections;

public class doorRandomize : MonoBehaviour {
    public Transform testDoor;

	// Use this for initialization
	void Start () {
        transform.position += new Vector3(-3f, -3f, -3f);
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnBecameInvisible()
    {
        Instantiate(testDoor, new Vector3(3f, 3f, 3f), Quaternion.identity);
        Destroy(gameObject);
    }
}