using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAsteroids : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform prefabToSpawn;
    public int objectCount = 1000;
    public float spawnCollisionCheckRadius;
    public int AsteroidFrequency = 10;
    public int tta = 10;
    //time til asteroids
    void Start()
    {
        SummonAsteroids();
    }

    void SummonAsteroids()
    {
        for (int loop = 0; loop < objectCount; loop++)
        {
            Vector3 spawnPoint;
            spawnPoint.z = transform.position.z + 45;
            spawnPoint.y = 2;
            spawnPoint.x = Random.Range(-15.0f, 15.0f);
            if (!Physics.CheckSphere(spawnPoint, spawnCollisionCheckRadius))
            {
                Instantiate(prefabToSpawn, spawnPoint, Random.rotation);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (tta >= AsteroidFrequency)
        {
            SummonAsteroids();
            tta = 0;
        }

        tta++;
    }
}
