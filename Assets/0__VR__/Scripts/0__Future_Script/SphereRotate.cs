using UnityEngine;

public class SphereRotate : MonoBehaviour
{
    void Update()
    {
        this.gameObject.transform.Rotate(0f, 20f * Time.deltaTime, 20f * Time.deltaTime) ;
        
    }
}
