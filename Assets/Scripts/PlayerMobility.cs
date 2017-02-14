using UnityEngine;
using System.Collections;


public class PlayerMobility : MonoBehaviour
{
    public float speed;

    void FixedUpdate()
    {
        //gets player to look in direction of mouse and speed rotation
        var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Quaternion rot = Quaternion.LookRotation(transform.position - mousePosition, Vector3.forward);

        //sets rotation on z axis only
        transform.rotation = rot;
        transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z);
       
        

    }
}

	