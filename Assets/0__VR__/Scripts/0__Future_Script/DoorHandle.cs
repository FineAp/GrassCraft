using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorHandle : MonoBehaviour
{
    public Door door;
    public GameObject lastParticlel;
    private int count = 0;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Hands") && count == 0)
        {
            door.closeDoor = false;
            door.openDoor = true;
            door.speed = 40f;
            lastParticlel.SetActive(true);   
        }

        else if(other.CompareTag("Hands") && count == 1 )
        {
            door.openDoor = false;
            door.closeDoor = true;
            door.speed = 40f;
            lastParticlel.SetActive(false);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Hands") && count == 0)
        {
            count ++;
        }

        else if(other.CompareTag("Hands") && count == 1)
        {
            count = 0;
        }
    }

}
