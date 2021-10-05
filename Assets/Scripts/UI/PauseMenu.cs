using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool IsGamePaused = false;

    public GameObject pauseMenuPanel, optionsMenuPanel, winPanel;
    public GameObject pauseFirstButton, optionsFirstButton, optionsClosedButton;
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

    public void Resume()
    {
        pauseMenuPanel.SetActive(false);
        optionsMenuPanel.SetActive(false);
        winPanel.SetActive(false);
        Time.timeScale = 1f;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        IsGamePaused = false;
    }
    public void onMenuButtonClick()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("StartMenu");
    }
    public void Pause()
    {
        pauseMenuPanel.SetActive(true);
        optionsMenuPanel.SetActive(false);
        Time.timeScale = 0f;
        IsGamePaused = true;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(pauseFirstButton);
    }
    public void OptionsMenu()
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
    public void CloseOptionsMenu()
    {
        optionsMenuPanel.SetActive(false);
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(optionsClosedButton);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void WIN()
    {
        Time.timeScale = 0f;
        IsGamePaused = true;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        winPanel.SetActive(true);
    }
}
