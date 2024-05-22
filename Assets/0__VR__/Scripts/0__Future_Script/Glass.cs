using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glass : MonoBehaviour
{
    public GameObject count;
    public CountdownTimer countDown;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Fire"))
        {
            count.SetActive(true);
            countDown.text.SetActive(true);
        }
    }


}
