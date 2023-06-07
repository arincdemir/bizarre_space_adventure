using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MeterCounter : MonoBehaviour
{
    public float timeToDistanceMultiplier;
    public float timePassed;
    public float score;
    public bool counting = true;

    float boostMultipler;
    Text txt;

 

    public static MeterCounter instance;

    void Start()
    {
        instance = this;
        timePassed = 0;
        score = 0;
        txt = GetComponent<Text>();
        PlayerPrefs.SetFloat("Score", 0f);
    }

    void Update()
    {
        boostMultipler = BackgroundVariables.instance.multipler;

        if (counting) {
            timePassed += Time.deltaTime * boostMultipler;
            score = timePassed * timeToDistanceMultiplier;
            txt.text = math.round(timePassed * timeToDistanceMultiplier).ToString() + " km";


        }
        

        if (SceneManager.GetActiveScene().name == "Endless" && PlayerPrefs.GetFloat("highScore") < score)
        {         
            PlayerPrefs.SetFloat("highScore" , math.round(score));
        }



    }

}
