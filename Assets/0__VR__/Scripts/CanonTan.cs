using UnityEngine;

public class CanonTan : MonoBehaviour
{
    private Rigidbody rb;

    public float power;
    
    public int x = -1;
    public float rangeStart = 0f;
    public float rangeEnd = 1.5f;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Vector3 forceDir = new Vector3(x, 0, Random.Range(rangeStart, rangeEnd));
        rb.AddForce(forceDir * power, ForceMode.Impulse);

        Destroy(this.gameObject, 3f);
        
    }


}
