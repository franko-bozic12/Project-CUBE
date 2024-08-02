using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject pauseButton;

    void Awake()
    {
        pauseButton = GameObject.Find("PauseButton");
    }

    //Nastavlja igru nakon pauziranja
    public void Resume()
    {
        Time.timeScale = 1f;
        Destroy(pauseMenu);
        pauseButton.SetActive(true);
        PauseButton.pauseCheck = false;
    }

    //Vraca igraca na glavni meni
    public void Menu()
    {
        Abilities.shield = false;
        AbilityHandler.piercerCheck = false;
        SceneManager.LoadScene(0);
        ScoreCounter.score = 0;
        Time.timeScale = 1f;
        PauseButton.pauseCheck = false;
        Enemy.speed = 1;
        EnemyElectricity.speed = 1;
        Abilities.cooldown2 = false;
        Abilities.cooldown3 = false;
    }
}
