using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rand_Torque : MonoBehaviour
{
    public Rigidbody2D rb;
    public float max;
    public float min;

    private void Start()
    {
        RandTorque();
    }
    void RandTorque()
    {
        float randTorque = Random.Range(min,max);
        rb.AddTorque(randTorque);
    }
}
