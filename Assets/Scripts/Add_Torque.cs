using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Add_Torque : MonoBehaviour
{
    public float force;
    public Rigidbody2D RB;
    void Start()
    {
        RB.AddTorque(force);
    }
}

