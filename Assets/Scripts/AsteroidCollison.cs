using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidCollison : MonoBehaviour
{

    private float maxY;
    public GameObject collisonParticlePrefab;
    ArrayList particles = new ArrayList();

    private void Start()
    {
        maxY = Camera.main.orthographicSize;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.GetContact(0).point.y < maxY)
        {
            if (collision.gameObject.tag == "Asteroid")
            {
                Vector2 pos = collision.GetContact(0).point;
                Instantiate(collisonParticlePrefab, pos, Quaternion.identity).transform.parent = transform;
                SoundManagerScript.instance.AsteroidCollision();
            }
        }
    }

    void OnDestroy()
    {
        foreach (GameObject particle in particles)
        {
            Destroy(particle);
        }
    }
}

    
