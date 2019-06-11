using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSavedGame : MonoBehaviour
{
    public void Load(GameController player)
    {
        //player.LoadPlayer();
        PlayerData data = SaveSystem.LoadPlayer();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + data.scene);
    }
}
