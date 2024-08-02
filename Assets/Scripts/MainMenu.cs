using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject highScore;
    public GameObject playButton;
    public GameObject quitButton;
    public GameObject leftButton;
    public GameObject rightButton;
    public GameObject colorButton;

    public void Play()
    {
        MenuFade.play = true;
    }

    public void LeftButton()
    {
        if(Customize.skinCheck != 1)
        {
            Customize.skinCheck -= 1;
        }
    }

    public void RightButton()
    {
        if (Customize.skinCheck != 4)
        {
            Customize.skinCheck += 1;
        }
    }

    public void Color()
    {
        highScore.SetActive(false);
        playButton.SetActive(false);
        quitButton.SetActive(false);
        leftButton.SetActive(false);
        rightButton.SetActive(false);
        colorButton.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit(); //Izlaz iz igre
    }
}
