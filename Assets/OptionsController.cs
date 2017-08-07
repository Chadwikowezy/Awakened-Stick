using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsController : MonoBehaviour
{
    public AudioSource music;

    public void ReturnMainMenu()
    {
        Application.LoadLevel("Main Menu");
    }

    public void DisableEnableMusic()
    {
        if (music.isPlaying)
        {
            music.Stop();
        }
        else
        {
            music.Play();
        }
    }

    public void QuitButton()
    {
        Application.Quit();
    }


}