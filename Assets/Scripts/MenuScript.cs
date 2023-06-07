using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    int levelIndex;

    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("Level"))
        {
            PlayerPrefs.SetInt("Level", 5);
        }
        if (!PlayerPrefs.HasKey("SkinNum"))
        {
            PlayerPrefs.SetInt("SkinNum", 0);
        }
        if (!PlayerPrefs.HasKey("MusicLoudness"))
        {
            PlayerPrefs.SetFloat("MusicLoudness", 1f);
        }
        if (!PlayerPrefs.HasKey("SoundEffectsLoudness"))
        {
            PlayerPrefs.SetFloat("SoundEffectsLoudness", 1f);
        }
        if (!PlayerPrefs.HasKey("Diamonds"))
        {
            PlayerPrefs.SetInt("Diamonds", 0);
        }
        if (!PlayerPrefs.HasKey("SS1"))
        {
            PlayerPrefs.SetInt("SS1", 0);
        }
        if (!PlayerPrefs.HasKey("SS2"))
        {
            PlayerPrefs.SetInt("SS2", 0);
        }
        if (!PlayerPrefs.HasKey("SS3"))
        {
            PlayerPrefs.SetInt("SS3", 0);
        }
        if (!PlayerPrefs.HasKey("MaxLevel"))
        {
            PlayerPrefs.SetInt("MaxLevel", 1);
        }
        PlayerPrefs.Save();

        levelIndex = PlayerPrefs.GetInt("Level");
        SoundManagerScript.instance.MenuBackground();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartLevel()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("Level"));
    }
    public void StarShopMenu()
    {
        SceneManager.LoadScene("Shop_Menu");
    }
    
    public void GoToSettings()
    {
        SceneManager.LoadScene("Settings_Menu");
    }

    public void GoToCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void GoToLevelSelector()
    {
        SceneManager.LoadScene("Level_Select");
    }
}
