using UnityEngine;

public class Ship : MonoBehaviour
{
    public float moveSpeed = 5.0f; // 이동 속도를 설정할 변수

    private Rigidbody rb;

    void Start()
    {
        // Rigidbody 컴포넌트를 가져옵니다.
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // 게임 오브젝트를 앞으로 이동시키는 벡터를 생성
        Vector3 moveDirection = transform.forward * moveSpeed;

        // Rigidbody를 사용하여 게임 오브젝트를 이동시킵니다.
        rb.velocity = moveDirection;
    }
}
