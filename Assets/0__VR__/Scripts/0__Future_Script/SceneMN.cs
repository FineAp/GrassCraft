using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMN : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Sea"))
        {
            SceneManager.LoadScene("4_Sea");
        }

        else if(other.CompareTag("Space"))
        {
            SceneManager.LoadScene("3_Space");
        }

        else if(other.CompareTag("Forest"))
        {
            SceneManager.LoadScene("5_Forest");
        }
    }

    public void Return()
    {
        SceneManager.LoadScene("1_Start");
    }

}
