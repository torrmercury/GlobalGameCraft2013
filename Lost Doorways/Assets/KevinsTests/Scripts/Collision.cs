using UnityEngine;
using System.Collections;

public class Collision : MonoBehaviour {
	CharacterController myController;

	//void OnControllerColliderHit(ControllerColliderHit hit ){
	//	if(hit.collider.CompareTag("spinner")){
	//		transform.Rotate(Vector3.up*10*Time.deltaTime);		
	//	}
		
	//}
	
	void Start(){
		myController = GetComponent<CharacterController>();		
	}
	void OnTriggerStay(Collider other){
		if(other.CompareTag("spinner")){
			transform.Rotate(Vector3.up*400*Time.deltaTime);	
		}
		else if(other.CompareTag("tred")){
			
			myController.Move(Vector3.forward*30*Time.deltaTime);
		}
		else if (other.CompareTag ("door")){
			Application.LoadLevel("YouWin");	
		}
	}
}
