using UnityEngine;

public class SpawnAtTarget : MonoBehaviour
{
    public Transform targetPosition; // 타겟 지점을 설정할 변수
    public GameObject prefabToSpawn; // 생성할 Prefab을 설정할 변수
    public GameObject canonParticle;

    private bool isShout = true;

    void Update()
    {
        if(isShout)
        {
            Invoke("Shout", Random.Range(1,3));
            isShout = false;
        }


    }

    void CanonParticleOFF()
    {
        canonParticle.SetActive(false);
        isShout = true;
    }

    void Shout()
    {

        canonParticle.SetActive(true);
        Invoke("CanonParticleOFF", 1.3f);

            // 타겟 위치에서 GameObject 생성
        if (targetPosition != null && prefabToSpawn != null)
        {
            Instantiate(prefabToSpawn, targetPosition.position, Quaternion.identity);
        }

    }
}
