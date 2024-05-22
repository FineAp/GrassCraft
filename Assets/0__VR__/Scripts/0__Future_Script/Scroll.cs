using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    public GameObject stick;

    public GameObject falseStick;

    private Vector3 startPos;
    private Quaternion startRot;


    public bool resetPos = false;

    void Start()
    {
        startPos = falseStick.transform.position;
        startRot = falseStick.transform.rotation;
        
    }

    void Update()
    {
        if(resetPos)
        {
            stick.transform.position = startPos;
            stick.transform.rotation = startRot;
            stick.SetActive(false);
            resetPos = false;
        }
    }
    
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            resetPos = true;
            falseStick.SetActive(true);

        }

    }

    void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            falseStick.SetActive(false);
            stick.SetActive(true);
        }
    }

}
