using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] enemy;
    public Transform[] spawnPoint;

    public float startTimeBtwSpawns;
    private float timeBtwSpawns;

    void Start()
    {
        timeBtwSpawns = startTimeBtwSpawns;
    }

    void Update()
    {
        if (timeBtwSpawns <= 0)
        {
            if (enemy.Length > 0 && spawnPoint.Length > 0)
            {
                int randEnemy = Random.Range(0, enemy.Length);
                int randSpawnPoint = Random.Range(0, spawnPoint.Length);
                Instantiate(enemy[randEnemy], spawnPoint[randSpawnPoint].position, Quaternion.identity);
            }
            else
            {
                Debug.LogError("Enemy or spawn point arrays are empty!");
            }
            timeBtwSpawns = startTimeBtwSpawns;
        }
        else
        {
            timeBtwSpawns -= Time.deltaTime;
        }
    }
}
