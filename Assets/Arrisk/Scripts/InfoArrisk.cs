using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoArrisk : MonoBehaviour
{
    public static InfoArrisk Instance;

    public Web web;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        web = GetComponent<Web>();
    }
}
