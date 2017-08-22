using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsControllerDosPointO : MonoBehaviour
{
    public AudioSource music;
    public GameObject tutorialUiOBJ;

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

    public void TutorialButton()
    {
        tutorialUiOBJ.SetActive(true);
    }
}
