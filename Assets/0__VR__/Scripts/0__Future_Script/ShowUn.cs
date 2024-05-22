using System.Collections.Generic;
using UnityEngine;

public class ShowUn : MonoBehaviour
{
    public GameObject tools;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Hands"))
        {
            tools.SetActive(false);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Hands"))
        {
            tools.SetActive(true);
        }
    }

}
