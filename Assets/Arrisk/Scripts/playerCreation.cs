using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerCreation : MonoBehaviour
{
    public Button nextSkinLeft, nextSkinRight, nextShirtLeft, nextShirtRight;
    public GameObject redBlack, blueBlack, redWhite, blueWhite;
    public bool choosenOne;
    // Start is called before the first frame update
    void Start()
    {
        redBlack.SetActive(true);
        redWhite.SetActive(false);
        blueBlack.SetActive(false);
        blueWhite.SetActive(false);
        nextSkinLeft.onClick.AddListener(NextSkinLeft);
        nextSkinRight.onClick.AddListener(NextSkinRight);
        nextShirtLeft.onClick.AddListener(NextShirtLeft);
        nextShirtRight.onClick.AddListener(NextShirtRight);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void NextSkinLeft()
    {
        redBlack.SetActive(true);
        redWhite.SetActive(false);
        blueBlack.SetActive(false);
        blueWhite.SetActive(false);
        choosenOne = false;
    }

    void NextSkinRight()
    {
        redBlack.SetActive(false);
        redWhite.SetActive(true);
        blueBlack.SetActive(false);
        blueWhite.SetActive(false);
        choosenOne = true;
    }

    void NextShirtLeft()
    {
        if (choosenOne)
        {
            redBlack.SetActive(false);
            redWhite.SetActive(false);
            blueBlack.SetActive(false);
            blueWhite.SetActive(true);
        } else
        {
            redBlack.SetActive(false);
            redWhite.SetActive(false);
            blueBlack.SetActive(true);
            blueWhite.SetActive(false);
        }

    }

    void NextShirtRight()
    {
        if (choosenOne)
        {
            redBlack.SetActive(false);
            redWhite.SetActive(true);
            blueBlack.SetActive(false);
            blueWhite.SetActive(false);
        }
        else
        {
            redBlack.SetActive(true);
            redWhite.SetActive(false);
            blueBlack.SetActive(false);
            blueWhite.SetActive(false);
        }
    }
}
