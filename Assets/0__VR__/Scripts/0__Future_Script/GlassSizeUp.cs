using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassSizeUp : MonoBehaviour
{
    public GameObject nowGlass;

    public float speed = 0.1f;
    public bool isUp = false;
    public float maxScale = 2.0f; // 특정 스케일 상한값 설정

    void Update()
    {
        if (isUp)
        {
            // 현재 스케일에 더해질 증가값 계산
            Vector3 scaleChange = new Vector3(1, 1, 1) * Time.deltaTime * speed;

            // 증가된 스케일 계산
            Vector3 newScale = transform.localScale + scaleChange;

            // 특정 스케일 상한값 이상으로 커지지 않도록 제한
            newScale = Vector3.Min(newScale, new Vector3(maxScale, maxScale, maxScale));

            // 새로운 스케일을 적용
            transform.localScale = newScale;
            nowGlass.transform.localScale = newScale;
        }
    }
}
