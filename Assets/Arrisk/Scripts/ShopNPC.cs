using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopNPC : MonoBehaviour
{
    public GameObject canvasControllers, canvasShop;
    public Button exit, addLife, addDamage;
    GameController player;

    // Start is called before the first frame update
    void Start()
    {
        exit.onClick.AddListener(ExitShop);
        addLife.onClick.AddListener(MoreLife);
        addDamage.onClick.AddListener(MoreDamage);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Time.timeScale = 0;
        canvasControllers.SetActive(false);
        canvasShop.SetActive(true);
    }

    void ExitShop()
    {
        Time.timeScale = 1;
        canvasControllers.SetActive(true);
        canvasShop.SetActive(false);
    }
    void MoreLife()
    {
        if (CoinsController.coinsAmount >= 400 || player.health < 5)
        {
            CoinsController.coinsAmount -= 400;
            player.health += 1;
        }
    }
    void MoreDamage()
    {
        if (CoinsController.coinsAmount >= 750)
        {
            CoinsController.coinsAmount -= 750;
            Enemy.damage += 1;
        }
    }
}
