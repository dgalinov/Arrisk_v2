using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int health;
    public float damage;
    public int coins;
    int level;

    public void Start()
    {
        LoadPlayer();
    }

    public void SavePlayer ()
    {
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer ()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        health = data.health;
        damage = data.damage;
        coins = data.coins;
        level = data.scene;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + level);
    }
}
