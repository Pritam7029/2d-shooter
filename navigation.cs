using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class navigation : MonoBehaviour
{


    public void Playbutton()
    {
        SceneManager.LoadScene(1);
    }
    public void quitbutton()
    {
        Application.Quit();
    }
    public void settingsbutton()
    {
        //SceneManager.LoadScene(2);
    }
    public void customizescreen()
    {
        //SceneManager.LoadScene(3);
    }
    public void multiplayer()
    {
        SceneManager.LoadScene("Loading");
    }
}
