using UnityEngine;
using System.Collections;

public class baseObstacle : MonoBehaviour{
    bool p1near = false;
    bool topped = false;
    float i = 0;

	void start(){
		
	}	
	
	void OnTriggerEnter() 
	{
		p1near = true;
		Debug.Log("sadiufhkj:");
	}
	
	void OnTriggerExit() 
	{
		p1near = false;
		Debug.Log("sadiufhkj:");
	}
	
    void Update()
    {
		if (p1near == true && topped == false)
        {
            if ( i < 55)
            {
                transform.position += new Vector3(0, 2, 0) * Time.deltaTime;
                i += 1;
            }
            else if (i >= 55)
            {
                topped = true;
                i = 0;
            }
        }
        else if (p1near == false && topped == true)
        {

            if (i < 55)
            {
                transform.position += new Vector3(0, -2, 0) * Time.deltaTime;
                i += 1;
            }
            else if (i >= 55)
            {
                topped = false;
                i = 0;
            }
        }
    }
}