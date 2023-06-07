using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SettingsManager : MonoBehaviour
{
    public Slider musicSlider;
    public Slider effectsSlider;

    // Start is called before the first frame update
    void Start()
    {
        musicSlider.GetComponent<Slider>().value = PlayerPrefs.GetFloat("MusicLoudness");
        effectsSlider.GetComponent<Slider>().value = PlayerPrefs.GetFloat("SoundEffectsLoudness");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoToMenu()
    {
        float musicLoudness = musicSlider.GetComponent<Slider>().value;
        float soundEffectsLoudness = effectsSlider.GetComponent<Slider>().value;

        PlayerPrefs.SetFloat("MusicLoudness", musicLoudness);
        PlayerPrefs.SetFloat("SoundEffectsLoudness", soundEffectsLoudness);
        PlayerPrefs.Save();

        SceneManager.LoadScene("Main Menu");
    }
}
