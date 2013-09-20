using UnityEngine;
using System.Collections;

public class NowYouSeeMe : MonoBehaviour {

	void  OnBecameInvisible ()
		
	{
		SendMessageUpwards("findNewLocation",SendMessageOptions.DontRequireReceiver);
	}
}
