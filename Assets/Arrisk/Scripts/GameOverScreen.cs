using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public int level;

    void Start()
    {
        Time.timeScale = 0;
    }

    public void RestartOnClick()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MainOnClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - level);
    }

    public void QuitOnClick()
    {
        Debug.Log("Saliendo del juego...");
        Application.Quit();
    }
}
