using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroids : MonoBehaviour
{
    public Transform playerPosition;
    // Start is called before the first frame update
    void Start()
    {
        playerPosition = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(playerPosition.position, transform.position);

        if (dist >= 45)
        {
            Destroy(gameObject);
        }
    }
}
