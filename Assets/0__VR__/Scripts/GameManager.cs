using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Slider hpBar; // UI Slider 객체를 연결합니다.
    public float maxHp = 100f; // 최대 체력
    public float hp = 100f; // 현재 체력

    public bool isShouted = false;

    void Start()
    {
        hpBar.value = hp / maxHp;
    }

    void Update()
    {
        if(isShouted)
        {
            hp -= 30f;
            HandleHp();
            isShouted = false;
        }
    }

    private void HandleHp()
    {
        hpBar.value = Mathf.Lerp(hpBar.value, hp / maxHp, Time.deltaTime * 10);
    }

}