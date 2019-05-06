using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnEnemu : MonoBehaviour
{
    public GameObject enemy;
    float randX;
    float randY;
    Vector2 whereToSpawn;
    public float spawnRate = 30f;
    float nextSpawn = 0.0f;
    void Start()
    {

    }


    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(-21.43f, 21f);
            randY = Random.Range(8.41f, -9f);
            whereToSpawn = new Vector2(randX, randY);
            Instantiate(enemy, whereToSpawn, Quaternion.identity);
        }
    }
}
