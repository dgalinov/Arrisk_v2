using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameController.health -= 1;
    }
}
