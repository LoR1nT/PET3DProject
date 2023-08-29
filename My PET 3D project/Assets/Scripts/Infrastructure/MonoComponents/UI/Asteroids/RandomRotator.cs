using UnityEngine;
using System.Collections;

public class RandomRotator : MonoBehaviour
{
    [SerializeField] private float tumble;
    [SerializeField] private GameObject ParticleSystem;

    void Start()
    {
        GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * tumble;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        GameObject explosion = Instantiate(ParticleSystem, transform.position, transform.rotation);
        Destroy(explosion, 5f);
    }
}