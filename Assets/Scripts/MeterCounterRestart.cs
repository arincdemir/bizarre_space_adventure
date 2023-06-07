using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class MeterCounterRestart : MonoBehaviour
{

    float score;
    Text txt;

    // Start is called before the first frame update
    void Start()
    {
        txt = GetComponent<Text>();
        score = PlayerPrefs.GetFloat("Score");
        txt.text = score.ToString() + " km";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
