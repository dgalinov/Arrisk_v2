using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyInTime : MonoBehaviour
{
    [SerializeField]
    float destroyTime = 2f;
    void Start()
    {
        Destroy(gameObject, destroyTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "shot")
        {
            Destroy(collision.gameObject);
        }
    }
}
