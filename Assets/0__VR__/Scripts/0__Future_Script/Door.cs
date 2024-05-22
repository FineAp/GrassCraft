using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public float speed = 1f;
    public float angel = 50f;

    public bool closeDoor = false;
    public bool openDoor = false;

    void Update()
    {
        if(openDoor == true)
        {
            // Rotate the door around its pivot point
            transform.Rotate(Vector3.forward * speed * Time.deltaTime);

            // Check if the door has rotated more than or equal to 90 degrees
            if (transform.rotation.eulerAngles.y >= angel)
            {
            // Stop the rotation by setting the speed to 0
                speed = 0f;
            }
            
        }

        if(closeDoor == true)
        {
            transform.Rotate(Vector3.back * speed * Time.deltaTime);

            if (transform.rotation.eulerAngles.y >= angel)
            {
                // Stop the rotation by setting the speed to 0
                speed = 0f;
            }

        }
    }
}
