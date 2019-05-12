using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health = 3f;
    public static float damage = 1f;
    public GameObject enemy;
    Player player;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "shot")
        {
            if (health > 0f)
            {
                health -= damage;
            }
            else
            {
                enemy.gameObject.SetActive(false);
                CoinsController.coinsAmount += 100;
            }
        }

        if (collision.name == "Player")
        {
            player.health -= 1;
        }
    }
}
