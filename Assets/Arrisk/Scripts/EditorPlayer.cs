using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EditorPlayer : MonoBehaviour
{
    public Button create;
    // Start is called before the first frame update
    void Start()
    {
        create.onClick.AddListener(CreateCharacter);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateCharacter()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
