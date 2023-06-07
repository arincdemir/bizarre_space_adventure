using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public float minY = -10;
    public float radius;
    float maxX;

    private void Start()
    {
        maxX = Camera.main.orthographicSize * Camera.main.aspect;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < minY)
        {
            Destroy(gameObject);
        }
        if(maxX + radius < transform.position.x || -maxX - radius > transform.position.x)
        {
            Destroy(gameObject);
        }

    }
}
