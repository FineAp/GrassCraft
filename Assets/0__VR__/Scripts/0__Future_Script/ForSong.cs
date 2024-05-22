using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForSong : MonoBehaviour
{
    public List<GameObject> forMovie = new List<GameObject>();

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            forMovie[0].SetActive(true); // 영화
            forMovie[1].SetActive(false); //소파
            forMovie[2].SetActive(false); //불 
            forMovie[3].SetActive(false); //텔레포트
            forMovie[4].SetActive(false);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            forMovie[0].SetActive(false); // 영화
            forMovie[1].SetActive(true); //소파
            forMovie[2].SetActive(true); //불 
            forMovie[3].SetActive(true);
            forMovie[4].SetActive(true);
        }
    }
}
