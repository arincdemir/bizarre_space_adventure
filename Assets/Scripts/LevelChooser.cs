using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelChooser : MonoBehaviour
{
    public int firstLvlBuildIndex = 5;
    public Sprite lockedTexture;
    // Start is called before the first frame update
    void Start()
    {
        LockButtons();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void LockButtons()
    {
        int maxLvl = PlayerPrefs.GetInt("MaxLevel");
        Button[] buttons = GameObject.FindObjectsOfType<Button>();
        foreach (Button but in buttons)
        {
            if (Char.IsDigit(but.name[3]))
            {
                if (maxLvl < Int32.Parse(but.name[3].ToString()))
                {
                    but.GetComponent<Image>().sprite = lockedTexture;
                    but.gameObject.GetComponentInChildren<Text>().enabled = false;
                }
            }
            else if (but.name == "Endless")
            {
                if (maxLvl < 9)
                {
                    but.GetComponent<Image>().sprite = lockedTexture;
                    but.gameObject.GetComponentInChildren<Text>().enabled = false;
                }
            }
        }
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void GoToLv1()
    {
        SceneManager.LoadScene(firstLvlBuildIndex);
    }

    public void GoToLv2()
    {
        if (PlayerPrefs.GetInt("MaxLevel") >= 2)
        {
            SceneManager.LoadScene(firstLvlBuildIndex + 1);
        }
    }
    public void GoToLv3()
    {
        if (PlayerPrefs.GetInt("MaxLevel") >= 3)
        {
            SceneManager.LoadScene(firstLvlBuildIndex + 2);
        }
    }
    public void GoToLv4()
    {
        if (PlayerPrefs.GetInt("MaxLevel") >= 4)
        {
            SceneManager.LoadScene(firstLvlBuildIndex + 3);
        }
    }
    public void GoToLv5()
    {
        if (PlayerPrefs.GetInt("MaxLevel") >= 5)
        {
            SceneManager.LoadScene(firstLvlBuildIndex + 4);
        }
    }
    public void GoToLv6()
    {
        if (PlayerPrefs.GetInt("MaxLevel") >= 6)
        {
            SceneManager.LoadScene(firstLvlBuildIndex + 5);
        }
    }
    public void GoToLv7()
    {
        if (PlayerPrefs.GetInt("MaxLevel") >= 7)
        {
            SceneManager.LoadScene(firstLvlBuildIndex + 6);
        }
    }
    public void GoToLv8()
    {
        if (PlayerPrefs.GetInt("MaxLevel") >= 8)
        {
            SceneManager.LoadScene(firstLvlBuildIndex + 7);
        }
    }
    public void GoToLvEndless()
    {
        if (PlayerPrefs.GetInt("MaxLevel") >= 9)
        {
            SceneManager.LoadScene(firstLvlBuildIndex + 8);
        }
    }
    

}
