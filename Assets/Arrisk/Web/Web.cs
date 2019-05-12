using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class Web : MonoBehaviour
{
    public static bool funca;
    void Start()
    {
        //StartCoroutine(GetDate("http://localhost/ArriskDB/GetDate.php"));
        //StartCoroutine(GetUsers("http://localhost/ArriskDB/GetUsers.php"));
        //StartCoroutine(Login("testuser", "123456"));
        //StartCoroutine(Register("testuser2", "testing@email.es", "123456"));
    }

    IEnumerator GetDate(string uri)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
            // Request and wait for the desired page.
            yield return webRequest.SendWebRequest();

            string[] pages = uri.Split('/');
            int page = pages.Length - 1;

            if (webRequest.isNetworkError)
            {
                Debug.Log(pages[page] + ": Error: " + webRequest.error);
            }
            else
            {
                Debug.Log(pages[page] + ":\nReceived: " + webRequest.downloadHandler.text);
            }
        }
    }

    IEnumerator GetUsers(string uri)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
            // Request and wait for the desired page.
            yield return webRequest.SendWebRequest();

            string[] pages = uri.Split('/');
            int page = pages.Length - 1;

            if (webRequest.isNetworkError)
            {
                Debug.Log(pages[page] + ": Error: " + webRequest.error);
            }
            else
            {
                Debug.Log(pages[page] + ":\nReceived: " + webRequest.downloadHandler.text);
            }
        }
    }

    public IEnumerator Login(string username, string password)
    {
        WWWForm form = new WWWForm();
        form.AddField("loginUser", username);
        form.AddField("loginPass", password);

        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/ArriskDB/login.php", form))
        {
            yield return www.SendWebRequest();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
            if (www.isNetworkError || www.isHttpError)
            {
                funca = false;
                Debug.Log(www.error);
            }
            else
            {
                funca = false;
                Debug.Log(www.downloadHandler.text);
            }
        }
    }

    public IEnumerator Register(string username, string email, string password)
    {
        WWWForm form = new WWWForm();
        form.AddField("loginUser", username);
        form.AddField("loginEmail", email);
        form.AddField("loginPass", password);

        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/ArriskDB/RegisterUser.php", form))
        {
            yield return www.SendWebRequest();

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 12);

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
            }
        }
    }
}
