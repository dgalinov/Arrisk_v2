using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCSurvivor : MonoBehaviour
{
    public GameObject canvasControllers, canvasStory1, canvasStory2, canvasStory3, canvasStory4, canvasStory5;
    public Button next, next2, next3, next4, exit;
    // Start is called before the first frame update
    void Start()
    {
        next.onClick.AddListener(Next);
        next2.onClick.AddListener(Next2);
        next3.onClick.AddListener(Next3);
        next4.onClick.AddListener(Next4);
        exit.onClick.AddListener(Exit);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Time.timeScale = 0;
        canvasControllers.SetActive(false);
        canvasStory1.SetActive(true);
    }

    void Next()
    {
        Time.timeScale = 0;
        canvasStory1.SetActive(false);
        canvasStory2.SetActive(true);
    }
    void Next2()
    {
        Time.timeScale = 0;
        canvasStory2.SetActive(false);

        canvasStory3.SetActive(true);
    }
    void Next3()
    {
        Time.timeScale = 0;
        canvasStory3.SetActive(false);

        canvasStory4.SetActive(true);
    }
    void Next4()
    {
        Time.timeScale = 0;
        canvasStory4.SetActive(false);

        canvasStory5.SetActive(true);
    }
    void Exit()
    {
        Time.timeScale = 1;
        canvasStory5.SetActive(false);
        canvasControllers.SetActive(true);
        //CoinsController.coinsAmount += 400;
    }
}
