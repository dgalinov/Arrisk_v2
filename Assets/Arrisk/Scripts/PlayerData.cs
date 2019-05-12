using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public class PlayerData
{
    public int health;
    public int coins;
    public float damage;
    public int scene;

    public PlayerData (Player player)
    {
        health = player.health;
        coins = player.coins;
        damage = player.damage;
        scene = SceneManager.GetActiveScene().buildIndex;
    }
}
