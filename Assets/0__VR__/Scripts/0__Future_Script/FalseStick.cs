using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FalseStick : MonoBehaviour
{
    public float minZ = -2f;
    public float maxZ = 2f;

    public float speed = 1f;
    private bool movingPositive = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        // Z 축 방향으로 이동
        float translation = speed * Time.deltaTime;
        if (!movingPositive)
        {
            translation = -translation;
        }

        transform.Translate(0f, 0f, translation);

        // Z 축 방향의 위치 제한을 추가하여 이동 반복
        if (transform.position.z <= minZ || transform.position.z >= maxZ)
        {
            movingPositive = !movingPositive;
        }

        // 위치 제한을 추가하여 Z 축 방향의 이동을 제한
        float clampedZ = Mathf.Clamp(transform.position.z, minZ, maxZ);
        transform.position = new Vector3(transform.position.x, transform.position.y, clampedZ);
    }
}
