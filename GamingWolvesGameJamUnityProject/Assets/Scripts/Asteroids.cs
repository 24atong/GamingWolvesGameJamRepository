using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroids : MonoBehaviour
{
    public Transform playerPosition;
    private float size = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3 (0.005f, 0.005f, 0.005f);
        playerPosition = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        float dist = transform.position.z - playerPosition.position.z;

        if (dist < -7)
        {
            Destroy(gameObject);
        }

        transform.position = transform.position + new Vector3(0, 0, -0.02f);

        if (size < Random.Range(0.5f, 1.5f))
        {
            size += 0.005f;
            transform.localScale = new Vector3(size, size, size);
        }
    }
}
