using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour
{

    public GameObject enemy;
    public GameObject player;
    float randX;
    readonly float randZ = -1f;
    Vector3 whereToSpawn;
    public float spawnRate = 5f;
    float nextSpawn = 5.0f;
    public float leftOne = -12f;
    public float rightOne = 14f;

    
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(leftOne, rightOne);
            whereToSpawn = new Vector3 (randX, transform.position.y, randZ);
            var e = Instantiate(enemy, whereToSpawn, Quaternion.identity);
            e.GetComponent<Pathfinding.AIDestinationSetter>().target = player.transform;
            e.GetComponent<SpriteFlipper>().player = player.transform;
        }
    }

  
}
