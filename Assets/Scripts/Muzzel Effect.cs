using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuzzelEffect : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject muzzle;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            MuzzelFlash();

        }
    }

    private void MuzzelFlash()
    {
        GameObject currentMuzzle = Instantiate(muzzle, spawnPoint.position, spawnPoint.rotation);
        currentMuzzle.transform.parent = spawnPoint;
    }


}
