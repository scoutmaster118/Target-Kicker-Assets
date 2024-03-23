using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuManagement : MonoBehaviour
{

    public void Play()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void Settings()
    {

    }

    public void Quit()
    {
        Application.Quit();
    }
    public void Back()
    {
        SceneManager.LoadScene(0);
    }

}
