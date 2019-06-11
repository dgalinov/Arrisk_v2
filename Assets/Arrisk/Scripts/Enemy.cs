using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health2 = 3f;
    public static int damage = 1;
    public GameObject enemy;
    public GameObject jugador;
    GameController player;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "shot")
        {
            if (health2 > 0f)
            {
                health2 -= damage;
            }
            else
            {
                enemy.gameObject.SetActive(false);
                CoinsController.coinsAmount += 100;
            }
        }
    }
}
