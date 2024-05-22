using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public GameObject fireSm;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Hands"))
        {
            fireSm.SetActive(true);
            print("in");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Hands"))
        {
            fireSm.SetActive(false);
            print("Exit");
        }
    }

}
