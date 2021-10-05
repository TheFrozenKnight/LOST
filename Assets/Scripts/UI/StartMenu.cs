using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class StartMenu : MonoBehaviour
{

    public GameObject optionsMenuPanel, creditsPanel;
    public GameObject optionsFirstButton, optionsClosedButton, creditsFirstButton, creditsClosedButton;
    public AudioSource[] audioSourceSFX, audioSourceMusic;

    private void Update()
    {
        if (AudioManager.Music)
        {
            foreach (var source in audioSourceMusic)
            {
                source.enabled = AudioManager.Music;
            }
        }
        else
        {
            foreach (var source in audioSourceMusic)
            {
                source.enabled = AudioManager.Music;
            }
        }

        if (AudioManager.Sfx)
        {
            foreach (var source in audioSourceSFX)
            {
                source.enabled = AudioManager.Sfx;
            }
        }
        else
        {
            foreach (var source in audioSourceSFX)
            {
                source.enabled = AudioManager.Sfx;
            }
        }
    }

    public void onPlayButtonClick()
    {
        SceneManager.LoadScene("Level1");
    }
    public void onOptionsButtonClick()
    {
        optionsMenuPanel.SetActive(true);
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(optionsFirstButton);
    }
    public void ToggleMusic()
    {
        AudioManager.ToggleMusic();
    }
    public void ToggleSFX()
    {
        AudioManager.ToggleSFX();
    }
    public void onOptionsBackButtonClick()
    {
        optionsMenuPanel.SetActive(false);
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(optionsClosedButton);
    }

    public void onCreditsButtonClick()
    {
        creditsPanel.SetActive(true);
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(creditsFirstButton);
    }
    public void onCreditsBackButtonClick()
    {
        creditsPanel.SetActive(false);
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(creditsClosedButton);
    }
    public void onExitButtonClick()
    {
        Application.Quit();
    }
}
