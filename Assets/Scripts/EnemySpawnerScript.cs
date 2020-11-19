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

    ////WAVES
    //public int Waves;
    //public int totalWaves = 5;
    //private int numWaves = 0;
    //public float timeTillWave = 0.0f;
    //public float waveTimer = 30f;

    ////ID SPAWNER
    //private int SpawnID;

    ////ENEMYS GAMEOBJECTS
    //public GameObject Enemy1;
    //public GameObject Enemy2;
    //public GameObject Enemy3;
    //public GameObject Enemy4;
    //public GameObject Enemy5;

    ////STATEMENTS
    //public int totalEnemy = 10;
    //private int numEnemy = 0;
    //private int spawnedEnemy = 0;

    //public bool Spawn = true;


    //private void Start()
    //{
    //    if (Spawn)
    //    {
    //        spawnEnemy();
    //    }
    //}

    // Update is called once per frame
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

    //private void spawnEnemy()
    //{
    //    GameObject Enemy
    //}
}
