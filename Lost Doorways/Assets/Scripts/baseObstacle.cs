using UnityEngine;
using System.Collections;

public class baseObstacle : MonoBehaviour{
    bool p1near = true;
    bool topped = false;
    float i = 0;

	void start(){
		
	}

    void Update()
    {
        if (p1near == true && topped == false)
        {
            if ( i < 7)
            {
                transform.position += new Vector3(0, 5, 0) * Time.deltaTime;
                i += 1;
                Debug.Log(i);
            }
            else if (i >= 7)
            {
                topped = true;
                p1near = false;
                Debug.Log("hi");
                i = 0;
                Debug.Log(i);
            }
        }
        else if (p1near == false && topped == true)
        {

            if (i < 7)
            {
                transform.position += new Vector3(0, -5, 0) * Time.deltaTime;
                i += 1;
                Debug.Log(i);
            }
            else if (i >= 7)
            {
                topped = false;
                p1near = true;
                Debug.Log("hi");
                i = 0;
                Debug.Log(i);
            }
        }
    }
}