using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rb : MonoBehaviour
{
    public float speed;
   

   void start()
    {
       
    }

		void FixedUpdate ()
    {
        //gets player to look in direction of mouse and at what speed it rotates to look.
        var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Quaternion rot = Quaternion.LookRotation(transform.position - mousePosition, Vector3.forward);

        //setsrotation to Z axis only.
        transform.rotation = rot;
        transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z);
       
	}
	
}
