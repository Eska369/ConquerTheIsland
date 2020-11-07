using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour
{

    public GameObject enemy;
    float randX;
    readonly float randZ = -1f;
    Vector3 whereToSpawn;
    public float spawnRate = 4f;
    float nextSpawn = 0.0f;


    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(-10f, 4f);
            whereToSpawn = new Vector3 (randX, transform.position.y, randZ);
            Instantiate(enemy, whereToSpawn, Quaternion.identity);
        }
    }
}
