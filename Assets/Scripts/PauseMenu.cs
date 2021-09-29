using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    public GameObject optionsMenu;

    void Update()
    {
        if (Input.GetKeyDown("escape") && !GameOverMenu.GameIsOver)
        {
            if (!GameIsPaused)
            {
                Pause();
            }
            else
            {
                Resume();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMainMenu()
    {
        //SceneManager.UnloadSceneAsync(1);
        Time.timeScale = 1f;
        GameIsPaused = false;
        Cursor.visible = true;
        SceneManager.LoadScene(0);
    }

    public void Quit()
    {
        PlayerPrefs.SetInt("OilCollected", 0);
        Application.Quit();
    }

    public void OpenOptionsMenu()
    {
        optionsMenu.SetActive(true);
    }

    public void CloseOptionsMenu()
    {
        optionsMenu.SetActive(false);
    }

}
