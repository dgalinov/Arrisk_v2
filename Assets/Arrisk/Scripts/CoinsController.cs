using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsController : MonoBehaviour
{
    public static int coinsAmount;
    private Text coinsCounter;
    Player player;

    // Start is called before the first frame update
    void Start()
    {
        coinsCounter = GetComponent<Text>();
        coinsAmount = player.coins;
    }

    // Update is called once per frame
    void Update()
    {
        coinsCounter.text = "Coins { " + coinsAmount + " }";
    }
}
