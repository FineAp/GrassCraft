using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindZone : MonoBehaviour
{
    public GameObject windBtn;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            windBtn.SetActive(true);

        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            windBtn.SetActive(false);

        }

    }
}
