using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class FuelMovement : MonoBehaviour
{
    public float playerFuelIncrease;
    float maxX;
    float maxY;

    void Start()
    {
        maxY = Camera.main.orthographicSize;
        maxX = maxY * Camera.main.aspect;
    }

    void Update()
    {
        if(transform.position.y < -maxY)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerMovement>().fuel += playerFuelIncrease;
            Destroy(gameObject);
        }    
    }
}
