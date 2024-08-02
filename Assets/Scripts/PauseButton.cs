using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseButton : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject pauseButton;

    public static bool pauseCheck = false;

    void Start()
    {
        pauseButton = GameObject.Find("PauseButton");
    }

    public void Pause() //Pauziranje igre
    {
        Time.timeScale = 0f;
        Instantiate(pauseMenu);
        pauseButton.SetActive(false);
        pauseCheck = true;
    }
}
