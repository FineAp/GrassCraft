using UnityEngine;

public class CamVR : MonoBehaviour
{
    public float narrowFOV = 30f; // 좁은 시야각으로 설정할 FOV 값
    public float originalFOV = 60f; // 원래의 FOV 값

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("VR")) // 콜라이더에 Player 태그가 있는 경우
        {
            Camera.main.fieldOfView = narrowFOV; // FOV를 좁게 설정
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("VR")) // 콜라이더에서 Player 태그가 나간 경우
        {
            Camera.main.fieldOfView = originalFOV; // FOV를 원래 값으로 설정
        }
    }
}
