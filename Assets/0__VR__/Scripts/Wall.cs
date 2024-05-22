using UnityEngine;

public class Wall : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("CanonTan"))
        {
            gameManager.isShouted = true;
            print("닿음");
        }
    }
}
