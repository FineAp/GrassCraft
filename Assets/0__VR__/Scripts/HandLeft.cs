using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandLeft : MonoBehaviour
{
    public ChangeCam change;


    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("CanonTrigger"))
        {
            change.isIn = true;

        }
    }
}
