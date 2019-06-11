using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthScript : MonoBehaviour
{
    GameController player;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.health += 1;
        Destroy(this.gameObject);
    }
}
