using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public GameObject playerCanonTan;
    public GameObject canonParticle;
    public Transform canonPos;

    public ChangeCam change;

    void Update()
    {

    }

    public void Shout()
    {
        canonParticle.SetActive(true);
        Invoke("CanonParticleOff", 1.3f);
        Instantiate(playerCanonTan, canonPos.position, Quaternion.identity);

    }

    public void Change()
    {
        change.isOut = true;
    }

    void CanonParticleOff()
    {
        canonParticle.SetActive(false);
    }

}
