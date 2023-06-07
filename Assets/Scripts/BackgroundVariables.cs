using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundVariables : MonoBehaviour
{

    public static BackgroundVariables instance;

    public float startDelay;
    public float height;
    public float BG_1_speed;
    public float BG_2_speed;
    public float BG_3_speed;
    public int multipler = 1;

    void Awake()
    {
        instance = this;
    }

}
