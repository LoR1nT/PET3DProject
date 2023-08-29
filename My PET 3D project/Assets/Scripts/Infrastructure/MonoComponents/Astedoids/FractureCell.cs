using UnityEngine;

public class FractureCell : MonoBehaviour
{
    Rigidbody _fracture;

    private void Awake()
    {
        _fracture = GetComponent<Rigidbody>();        
    }

    void Start()
    {
        _fracture.velocity = transform.forward * Time.deltaTime * 5;
        Destroy(gameObject, 5f);
    }

}
