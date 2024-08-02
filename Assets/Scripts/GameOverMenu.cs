using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public static bool abilityCheck = false;

    //Poziva se ako je pritisnut Menu gumb
    public void Menu()
    {
        SceneManager.LoadScene(0);
        ScoreCounter.score = 0;
        Enemy.speed = 1;
        EnemyElectricity.speed = 1;
        AbilityHandler.piercerCheck = false;
        Abilities.cooldown2 = false;
        Abilities.cooldown3 = false;
    }

    //Poziva se ako je pritisnut Restart gumb
    public void Restart()
    {
        SceneManager.LoadScene(1);
        ScoreCounter.score = 0;
        Enemy.speed = 1;
        EnemyElectricity.speed = 1;
        AbilityHandler.piercerCheck = false;
        Abilities.cooldown2 = false;
        Abilities.cooldown3 = false;
    }
}
