using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public float countdownTime = 10f; // 카운트 다운 시간 (초)
    public Text countdownText; // UI Text 오브젝트
    public GameObject titleCanvas;
    public GameObject text;
    public GameObject work;

    private bool isCountingDown = false;

    void Start()
    {
        // 시작 시에 UI 텍스트 업데이트
        UpdateCountdownText();
    }

    void Update()
    {
        if (isCountingDown)
        {
            // 시간이 흐를 때마다 카운트 다운
            countdownTime -= Time.deltaTime;

            // UI 텍스트 업데이트
            UpdateCountdownText();

            // 카운트 다운이 끝났을 때 처리
            if (countdownTime <= 0f)
            {
                countdownTime = 0f;
                isCountingDown = false;
                OnCountdownComplete();
            }
        }
    }

    void UpdateCountdownText()
    {
        // UI 텍스트에 남은 시간 표시
        countdownText.text = Mathf.Ceil(countdownTime).ToString();
    }

    void OnCountdownComplete()
    {
        // 카운트 다운이 완료되면 원하는 동작 수행
        text.SetActive(false);
        work.SetActive(true);
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Glass")) 
        {
            isCountingDown = true;
            text.SetActive(true);
            UpdateCountdownText();
            work.SetActive(true);
            titleCanvas.SetActive(false);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Glass"))
        {
            isCountingDown = false;
            countdownTime = 10f;
            text.SetActive(false);
            work.SetActive(true);   
            titleCanvas.SetActive(true);
        }
    }

}
