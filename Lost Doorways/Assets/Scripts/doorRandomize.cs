using UnityEngine;
using System.Collections;

public class doorRandomize : MonoBehaviour {
    public Transform datDoor;
    int rng = 0;
    
	// Use this for initialization
	void Start () {
        if (datDoor.renderer.isVisible)
        {
            Instantiate(datDoor, new Vector3(Random.Range(-2f, 2f), 0f, 2.98f), Quaternion.identity);
            Destroy(gameObject);
        }
	}
	
	// Update is called once per frame
	void Update () {
        rng = Random.Range(0, 3);
	}

    void OnBecameInvisible()
    {
        if (rng == 0)
        {
            Instantiate(datDoor, new Vector3(Random.Range(-4.5f, 4.5f), 0f, 8.9f), Quaternion.identity);
            Destroy(gameObject);
        }
        if (rng == 1)
        {
            Instantiate(datDoor, new Vector3(Random.Range(-4.5f, 4.5f), 0f, -8.9f), Quaternion.identity);
            Destroy(gameObject);
        }
        if (rng == 2)
        {
            Instantiate(datDoor, new Vector3(Random.Range(-2f, 2f), 0f, 2.98f), Quaternion.identity);
            Destroy(gameObject);
        }
        if (rng == 3)
        {
            Instantiate(datDoor, new Vector3(Random.Range(-2f, 2f), 0f, 2.98f), Quaternion.identity);
            Destroy(gameObject);
        }
        
    }
}