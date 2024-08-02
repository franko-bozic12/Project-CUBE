using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityChoose1 : MonoBehaviour
{
    public GameObject pauseButton;
    public GameObject bullet;
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
        bullet.transform.localScale = new Vector3(30f, 30f, 30f);
        Time.timeScale = 1f;
        PauseButton.pauseCheck = false;
        pauseButton.SetActive(true);
        Destroy(gameObject);
    }

    //Poziva se ako igrač izabere drugi ability
    public void Ability2()
    {
        abilityChoose = 2;
        FirePoint.startingBullets = 3;
        Time.timeScale = 1f;
        PauseButton.pauseCheck = false;
        pauseButton.SetActive(true);
        Destroy(gameObject);
    }
}
