using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondMovement : MonoBehaviour
{
    float maxY;

    // Start is called before the first frame update
    void Start()
    {
        maxY = Camera.main.orthographicSize;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -maxY)
        {
            Destroy(gameObject);
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            PlayerPrefs.SetInt("Diamonds", PlayerPrefs.GetInt("Diamonds") + 1);
            Destroy(gameObject);
        }
    }
}
