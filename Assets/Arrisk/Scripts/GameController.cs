using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject hp5, hp4, hp3, hp2, hp1, pauseButton, bl, br, bj, bs, textC;
    public Canvas canvasGameOver;
    public int health = 5;
    public int damage = 1;
    public int coins;
    int level;

    void Start()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        health = data.health;
        damage = data.damage;
        coins = data.coins;
        hp5.gameObject.SetActive(true);
        hp4.gameObject.SetActive(true);
        hp3.gameObject.SetActive(true);
        hp2.gameObject.SetActive(true);
        hp1.gameObject.SetActive(true);
        pauseButton.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (health > 5)
        {
            SaveSystem.SavePlayer(this);
            health = 5;
        }
        switch (health)
        {
            case 5:
                hp5.gameObject.SetActive(true);
                hp4.gameObject.SetActive(true);
                hp3.gameObject.SetActive(true);
                hp2.gameObject.SetActive(true);
                hp1.gameObject.SetActive(true);
                SaveSystem.SavePlayer(this);
                break;
            case 4:
                hp5.gameObject.SetActive(false);
                hp4.gameObject.SetActive(true);
                hp3.gameObject.SetActive(true);
                hp2.gameObject.SetActive(true);
                hp1.gameObject.SetActive(true);
                SaveSystem.SavePlayer(this);
                break;
            case 3:
                hp5.gameObject.SetActive(false);
                hp4.gameObject.SetActive(false);
                hp3.gameObject.SetActive(true);
                hp2.gameObject.SetActive(true);
                hp1.gameObject.SetActive(true);
                SaveSystem.SavePlayer(this);
                break;
            case 2:
                hp5.gameObject.SetActive(false);
                hp4.gameObject.SetActive(false);
                hp3.gameObject.SetActive(false);
                hp2.gameObject.SetActive(true);
                hp1.gameObject.SetActive(true);
                SaveSystem.SavePlayer(this);
                break;
            case 1:
                hp5.gameObject.SetActive(false);
                hp4.gameObject.SetActive(false);
                hp3.gameObject.SetActive(false);
                hp2.gameObject.SetActive(false);
                hp1.gameObject.SetActive(true);
                SaveSystem.SavePlayer(this);
                break;
            case 0:
                hp5.gameObject.SetActive(false);
                hp4.gameObject.SetActive(false);
                hp3.gameObject.SetActive(false);
                hp2.gameObject.SetActive(false);
                hp1.gameObject.SetActive(false);
                bl.gameObject.SetActive(false);
                br.gameObject.SetActive(false);
                bj.gameObject.SetActive(false);
                bs.gameObject.SetActive(false);
                textC.gameObject.SetActive(false);
                pauseButton.gameObject.SetActive(false);
                canvasGameOver.gameObject.SetActive(true);
                break;
        }
    }

    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }
}
