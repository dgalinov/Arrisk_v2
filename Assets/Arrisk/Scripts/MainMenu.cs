﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    int health;
    float damage;
    int coins;
    int level;

    void Start()
    {

    }

    public void Hard()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }
    public void Easy()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    public void Continue()
    {
        LoadPlayer();
    }
    public void QuitGame() {
	Debug.Log("QUIT!");
	Application.Quit();
    }
    public void LogOut()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        level = data.scene;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + level);
    }
}
