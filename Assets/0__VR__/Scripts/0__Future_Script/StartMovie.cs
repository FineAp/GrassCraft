using UnityEngine;

public class StartMovie : MonoBehaviour
{
    public GameObject map;
    public GameObject blackMusic;
    

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            blackMusic.SetActive(true);
            map.SetActive(false);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            map.SetActive(true);
            blackMusic.SetActive(false);
        }
    }
}
