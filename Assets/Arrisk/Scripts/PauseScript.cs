using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseScript : MonoBehaviour
{
    public UnityEngine.UI.Button pauseButton, resumeButton, restartButton, mainButton, quitButton;
    public GameObject PauseCanvas, GameCanvas;
    public int level;

    void Start()
    {
        resumeButton.onClick.AddListener(ResumeOnClick);
        pauseButton.onClick.AddListener(PauseOnClick);
        quitButton.onClick.AddListener(QuitOnClick);
    }

    void PauseOnClick()
    {
        Time.timeScale = 0;
        GameCanvas.gameObject.SetActive(false);
        PauseCanvas.gameObject.SetActive(true);
    }

    void ResumeOnClick()
    {
        Time.timeScale = 1;
        GameCanvas.gameObject.SetActive(true);
        PauseCanvas.gameObject.SetActive(false);
    }

    void RestartOnClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Debug.Log("Reiniciando del juego...");
    }

    void MainOnClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + level);
    }

    void QuitOnClick()
    {

        Debug.Log("Saliendo del juego...");
        Application.Quit();
    }

}
