using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAsteroids : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform prefabToSpawn;
    public int objectCount = 50;
    public float spawnRadius = 5;
    public float spawnCollisionCheckRadius;
    public int moreAsteroidsDist = 0;
    void Start()
    {
        SummonAsteroids();
    }

    void SummonAsteroids()
    {
        for (int loop = 0; loop < objectCount; loop++)
        {
            Vector3 spawnPoint = (transform.position + Random.insideUnitSphere * spawnRadius);
            spawnPoint.z += 30;
            spawnPoint.y = 2;
            if (!Physics.CheckSphere(spawnPoint, spawnCollisionCheckRadius))
            {
                Instantiate(prefabToSpawn, spawnPoint, Random.rotation);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position.z >= moreAsteroidsDist)
        {
            SummonAsteroids();
            moreAsteroidsDist += 30;
        }
        
    }
}
