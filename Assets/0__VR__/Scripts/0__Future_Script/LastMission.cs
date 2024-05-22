using UnityEngine;
using UnityEngine.SceneManagement;

public class LastMission : MonoBehaviour
{
    public GameObject glass;
    public GameObject finishUi;
    public float time = 10f;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Glass"))
        {
            Destroy(glass);
            finishUi.SetActive(true);

            Invoke("Success", time);
        }
    }

    void Success()
    {
        SceneManager.LoadScene("1_Start");

    }

}
