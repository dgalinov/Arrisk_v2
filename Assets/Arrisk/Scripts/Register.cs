using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Register : MonoBehaviour
{
    public InputField usernameInput;
    public InputField emailInput;
    public InputField passwordInput;
    public Button registerButton;

    // Start is called before the first frame update
    void Start()
    {
        registerButton.onClick.AddListener(() =>
        {
            StartCoroutine(InfoArrisk.Instance.web.Register(usernameInput.text, emailInput.text, passwordInput.text));
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 12);
        });
    }
}
