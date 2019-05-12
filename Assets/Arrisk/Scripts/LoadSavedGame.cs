using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSavedGame : MonoBehaviour
{
    public void Load(Player player)
    {
        player.LoadPlayer();
    }
}
