using UnityEngine;

public class BlasterBulletScript : MonoBehaviour
{
    public Rigidbody Rigidbody;
    public GameObject BlasterBullet;
    public GameObject BlasterBulletParticleSystem;
    public float time;

    private void Update()
    {

        if (time > 0)
        {
            time -= Time.deltaTime;
        }
        else
        {
            BulletDestroy();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        BulletDestroy();
    }

    public void BulletDestroy()
    {
        Object.Destroy(BlasterBullet);
        GameObject explosion = Instantiate(BlasterBulletParticleSystem, BlasterBullet.transform.position, BlasterBullet.transform.rotation);
        Destroy(explosion, 1.1f);
    }
}
