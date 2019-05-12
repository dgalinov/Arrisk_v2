using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    public InputField usernameInput;
    public InputField passwordInput;
    public Button loginButton, registerButton;

    // Start is called before the first frame update
    void Start()
    {
        loginButton.onClick.AddListener(() =>
        {
            StartCoroutine(InfoArrisk.Instance.web.Login(usernameInput.text, passwordInput.text));
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
        });
    }
}
