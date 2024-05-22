using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCam : MonoBehaviour
{
    public GameObject player;
    public GameObject canonPlayer;

    private Transform startPos;

    public bool isOut = false;
    public bool isIn = false;

    void Start()
    {
        startPos = player.transform;

    }

    void Update()
    {
        Telleport();
    }

    void Telleport()
    {
        if(isOut)
        {
            player.transform.position = startPos.position;
            player.SetActive(true);
            canonPlayer.SetActive(false);
            isOut = false;

        }

        if(isIn)
        {
            player.SetActive(false);
            canonPlayer.SetActive(true);
            isIn = false;

        }

    }

}
