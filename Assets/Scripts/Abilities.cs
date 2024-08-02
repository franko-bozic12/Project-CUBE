using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abilities : MonoBehaviour
{
    public GameObject timeSlowParticles;
    public static bool shield = false;
    public static bool destroyer = false;
    public static bool cooldown3 = false;
    public static bool cooldown2 = false;

    //Funkcija koja se poziva kada igrač pritisne gumb za usporavanje vremena
    public void TimeSlow()
    { 
        if (Enemy.speed == 1)
        {
            Enemy.speed = 0.3f;
            EnemyElectricity.speed = 0.3f;
            Vector3 position = new Vector3(0, 10, 0);
            Instantiate(timeSlowParticles, position, Quaternion.identity);
            Invoke("TimeSlowBreak", 10);
        }
    }

    //Funkcija koja se poziva kada igrač pritisne gumb za stavljanje štita
    public void Shield()
    {
        shield = true;
        Invoke("ShieldBreak", 10);
    }

    //Funkcija se poziva kada igrač pristisne gumba za unistavanje svih neprijatelja
    public void Destroyer()
    {
        destroyer = true;
        Invoke("DestroyerBreak", 1);
    }

    public void Pierce()
    {
        AbilityHandler.piercerCheck = true;
        Invoke("PierceBreak", 20);
    }

    //Prekida unistavanje
    void DestroyerBreak()
    {
        destroyer = false;
        cooldown3 = true;
        Invoke("Cooldown3End", 40);
    }

    //Prekida stit
    void ShieldBreak()
    {
        shield = false;
        cooldown2 = true;
        Invoke("Cooldown2End", 20);
    }

    //Prekida usporavanje vremena
    void TimeSlowBreak()
    {
        Enemy.speed = 1;
        EnemyElectricity.speed = 1;
        cooldown3 = true;
        Invoke("Cooldown3End", 20);
    }

    void PierceBreak()
    {
        cooldown2 = true;
        AbilityHandler.piercerCheck = false;
        Invoke("Cooldown2End", 30);
    }

    //Pokrece cooldown na drugom prozoru
    void Cooldown2End()
    {
        cooldown2 = false;
    }

    void Cooldown3End()
    {
        cooldown3 = false;
    }
}
