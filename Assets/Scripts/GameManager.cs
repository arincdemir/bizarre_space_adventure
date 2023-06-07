using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public float winningDistance = 1000;
    public GameObject replayButton;
    public GameObject nextLevelButton;
    public GameObject menuButton;

    GameObject player;
    GameObject[] asteroids;

    bool isBoosting = false;
    public Vector2 force;
    public int levelNumberIndexGap = 4;



    // Start is called before the first frame update
    void Start()
    {
        

        if(instance == null)
        {
            instance = this;
        }
        SoundManagerScript.instance.GameBackground();
        //Screen.SetResolution(480, 800, false);
    }

    bool enteredWinningScreen = false;

    // Update is called once per frame
    void Update()
    {
        if (isBoosting)
        {
            Boosting();
        }

        
       
        if (MeterCounter.instance.score >= winningDistance && !enteredWinningScreen)
        {
            enteredWinningScreen = true;
            WinScreen();
        }
    }

    void WinScreen()
    {
        GameObject.FindGameObjectWithTag("Asteroid Spawner").SetActive(false);
        GameObject.FindGameObjectWithTag("Fuel Spawner").GetComponent<FuelSpawner>().enabled = false;
        PlayerMovement.ableToMove = false;
        nextLevelButton.SetActive(true);
        menuButton.SetActive(true);
        int nextIndex = SceneManager.GetActiveScene().buildIndex + 1;
        PlayerPrefs.SetInt("Level", nextIndex);
        if (PlayerPrefs.GetInt("MaxLevel") < nextIndex - levelNumberIndexGap) {
            PlayerPrefs.SetInt("MaxLevel", nextIndex - levelNumberIndexGap);
        }
        PlayerPrefs.Save();
    }

    public void GoToNextLevel()
    {
        PlayerMovement.ableToMove = true;
        int nextIndex = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(nextIndex);
        
    }

    public void LoseScreen()
    {
        replayButton.SetActive(true);
        menuButton.SetActive(true);
        MeterCounter.instance.counting = false;
        
    }

    public void ReplayLevel()
    {
        PlayerMovement.ableToMove = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void BoostEffect()
    {
        BackgroundVariables.instance.multipler = 10;

        isBoosting = true;
        Invoke("StopBoost", 2);

    }
    public void StopBoost(){
        BackgroundVariables.instance.multipler = 1;
        isBoosting = false;

    }
    void Boosting()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        asteroids = GameObject.FindGameObjectsWithTag("Asteroid");

        for (int i = 0; i < asteroids.Length; i++)
        {
            if (player.transform.position.x < asteroids[i].transform.position.x)
            {
                asteroids[i].GetComponent<Rigidbody2D>().AddForce(force * Time.deltaTime);
            }
            else
            {
                asteroids[i].GetComponent<Rigidbody2D>().AddForce(-force * Time.deltaTime);
            }
        }
    }

}

