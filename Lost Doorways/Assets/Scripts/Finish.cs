using UnityEngine;
using System.Collections;

public class Finish : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	void OnTriggerEnter()
	{
		Application.LoadLevel ("The Room");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
