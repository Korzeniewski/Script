using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnBlock : MonoBehaviour
{
    public GameObject enemy;
    float randX;
    float randY;
    float randZ;
    Vector2 whereToSpawn;
    public float spawnRate = 2f;
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
            randZ = Random.Range(0f,180f);
            whereToSpawn = new Vector2(randX, randY);
            Instantiate(enemy, whereToSpawn, Quaternion.Euler(0,0,randZ));
        }
    }

}
