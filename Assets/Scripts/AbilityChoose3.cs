using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityChoose3 : MonoBehaviour
{
    public GameObject pauseButton;
    public static int abilityChoose = 0;

    void Awake()
    {
        pauseButton = GameObject.Find("PauseButton");
        pauseButton.SetActive(false);
    }

    //Poziva se ako igrač izabere prvi ability
    public void Ability1()
    {
        abilityChoose = 1;
        Time.timeScale = 1f;
        PauseButton.pauseCheck = false;
        pauseButton.SetActive(true);
        Destroy(gameObject);
    }

    //Poziva se ako igrač izabere drugi ability
    public void Ability2()
    {
        abilityChoose = 2;
        Time.timeScale = 1f;
        PauseButton.pauseCheck = false;
        pauseButton.SetActive(true);
        Destroy(gameObject);
    }
}
