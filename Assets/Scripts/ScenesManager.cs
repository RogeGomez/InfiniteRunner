using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    public GameObject pausePanel;
    public GameObject gameOverPanel;

    private bool pausePanelActive;

    public void StartGame()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

    public void Pause()
    {
        if (pausePanelActive)
        {
            pausePanelActive = false;
            pausePanel.SetActive(false);
            Time.timeScale = 1;
        }
        else
        {
            pausePanelActive = true;
            pausePanel.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void RestarGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("QUITTING GAME");
    }

    public void ContinueGame()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0;
    }
}
