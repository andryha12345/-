using UnityEngine;



public class Gun : MonoBehaviour
{


    public float damage = 100f;
    public float range = 100f;
    public Camera fpsCam;
    public ParticleSystem muzzleFlash;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();

        }
    }
    void Shoot()
    {


        RaycastHit hit;

        if (Physics.Raycast(fpsCamera.transform.position, fpsCamera.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();

            if (target != null)
            {
                target.TakeDamage(damage);

            }

        }
    }
}
