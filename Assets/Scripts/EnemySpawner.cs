using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public GameObject enemyElectricity;
    public float delay;

    private float startingDelay = 0f;

    void Update()
    {
        for(int i = 0; i < 5; i++)  //Stvaranje neprijatelja
        {
            Invoke("CreateEnemy", startingDelay);
            startingDelay += delay;
        }
        if(delay > 0.6)
            delay -= 0.2f;
    }

    //Funkcija za tsvaranje neprijatelja
    void CreateEnemy()
    {
        Vector3 position = new Vector3(Random.Range(-7f, 7f), 20, 0);
        Instantiate(enemy, position, Quaternion.identity);
        Instantiate(enemyElectricity, position, Quaternion.identity);
    }
}
