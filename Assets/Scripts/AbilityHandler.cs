using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityHandler : MonoBehaviour
{
    public GameObject bulletGrowButton;
    public GameObject bulletPlusButton;
    public GameObject shieldButton;
    public GameObject piercerButton;
    public GameObject timeSlowButton;
    public GameObject destroyButton;
    public GameObject abilityChoose1;
    public GameObject abilityChoose2;
    public GameObject abilityChoose3;
    public GameObject cooldown3;
    public GameObject cooldown2;
    public GameObject shield;
    public GameObject bullet;
    public GameObject gameOverCover;
    public static bool gameOverCoverCheck = false;
    public static bool abilityCheck = false;
    public static bool piercerCheck = false;
    public static bool shieldDestroy = false;

    private float scoreCheck = 100;

    void Start()
    {
        bullet.transform.localScale = new Vector3(15f, 15f, 15f);
        shieldDestroy = false;
        gameOverCoverCheck = false;
    }

    void Update()
    {
        //Provjera za pozivanje prozora za biranje Ability-a
        if(ScoreCounter.score >= scoreCheck && scoreCheck <= 1000)
        {
            PauseButton.pauseCheck = true;
            Time.timeScale = 0f;
            if(scoreCheck == 100)
            {
                Instantiate(abilityChoose1);
                scoreCheck = 500;
            }
            else if(scoreCheck == 500)
            {
                Instantiate(abilityChoose2);
                scoreCheck = 1000;
            }
            else if(scoreCheck == 1000)
            {
                Instantiate(abilityChoose3);
                scoreCheck = 1001;
            }
        }

        //Provjera za kraj igre
        if(gameOverCoverCheck == true)
        {
            gameOverCover.SetActive(true);
        }
        else if(gameOverCoverCheck == false)
        {
            gameOverCover.SetActive(false);
        }

        //Provjera za instanciranje stita
        if (Abilities.shield == true && shieldDestroy == false)
        {
            shield.SetActive(true);
        }
        else if(Abilities.shield == false && shieldDestroy == false)
        {
            shield.SetActive(false);
        }
        
        //Provjera treceg cooldown prozora
        if (Abilities.cooldown3 == true)
        {
            cooldown3.SetActive(true);
        }
        else
        {
            cooldown3.SetActive(false);
        }

        //Provjera drugog cooldown prozora
        if (Abilities.cooldown2 == true)
        {
            cooldown2.SetActive(true);
        }
        else
        {
            cooldown2.SetActive(false);
        }
        
        //Provjera izabranog Ability-a
        if (AbilityChoose1.abilityChoose == 1)
        {
            bulletGrowButton.SetActive(true);
            AbilityChoose1.abilityChoose = 0;
        }
        else if(AbilityChoose1.abilityChoose == 2)
        {
            bulletPlusButton.SetActive(true);
            AbilityChoose1.abilityChoose = 0;
        }

        //Provjera izabranog Ability-a
        if (AbilityChoose2.abilityChoose == 1)
        {
            shieldButton.SetActive(true);
            AbilityChoose2.abilityChoose = 0;
        }
        else if (AbilityChoose2.abilityChoose == 2)
        {
            piercerButton.SetActive(true);
            AbilityChoose2.abilityChoose = 0;
        }

        //Provjera izabranog Ability-a
        if (AbilityChoose3.abilityChoose == 1)
        {
            timeSlowButton.SetActive(true);
            AbilityChoose3.abilityChoose = 0;
        }
        else if (AbilityChoose3.abilityChoose == 2)
        {
            destroyButton.SetActive(true);
            AbilityChoose3.abilityChoose = 0;
        }
    }
}
