using UnityEngine;

public class Player : MonoBehaviour
{
    public ChangeCam change;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Canon"))
        {
            change.isIn = true;
        }
    }
}
