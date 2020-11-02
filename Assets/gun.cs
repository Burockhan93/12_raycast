

using UnityEngine;

public class gun : MonoBehaviour
{
    public float damage=10;
    public float range=100;
    public float force = 10f;
    public float fireRate = 30f;
    private float nextFire = 0;


    public ParticleSystem muzzle;
    public Camera cam;
    public GameObject impact;

     void Update()
    {
        if (Input.GetButton("Fire1") && Time.time >=nextFire  )
        {
            nextFire = Time.time + 1f / fireRate; // pespese atesi engelliyor belli süre sonra
            Shoot();
        }

        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward)*1000, Color.yellow);
    }
    void Shoot()
    {
        muzzle.Play();
        RaycastHit hit;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            enemy enemy = hit.transform.GetComponent<enemy>();
            if (enemy != null)
            {
                enemy.TakeDamage(damage);
            }
            GameObject inst = Instantiate(impact, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(inst, 0.5f);
            if (hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal*force);
            }

        }
       
    }
}
