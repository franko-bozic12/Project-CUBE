using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public Transform player;
    public GameObject gameOver;
    public GameObject enemyParticles;
    public GameObject pauseButton;
    public GameObject floating20;
    public GameObject floating10;
    public GameObject floating5;
    public static float speed = 1;

    void Start()
    {
        pauseButton = GameObject.Find("PauseButton");
    }

    void Update()
    {
        //Unstava neprijatelja ako je aktiviran destroyer
        if (Abilities.destroyer == true && transform.position.y >= 15)
        {
            ScoreCounter.score += 20;
            Instantiate(floating20, transform.position, Quaternion.identity);
            Vector3 position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
            Instantiate(enemyParticles, position, Quaternion.identity);
            Destroy(gameObject);
        }
        else if (Abilities.destroyer == true && transform.position.y >= 10)
        {
            ScoreCounter.score += 10;
            Instantiate(floating10, transform.position, Quaternion.identity);
            Vector3 position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
            Instantiate(enemyParticles, position, Quaternion.identity);
            Destroy(gameObject);
        }
        else if (Abilities.destroyer == true && transform.position.y < 10)
        {
            ScoreCounter.score += 5;
            Instantiate(floating5, transform.position, Quaternion.identity);
            Vector3 position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
            Instantiate(enemyParticles, position, Quaternion.identity);
            Destroy(gameObject);
        }
        transform.LookAt(player);
        transform.position += transform.forward * speed * Time.deltaTime;
        if(transform.position.y <= 2)
            Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other) //Provjera kolizije s objektima
    {
        if(other.gameObject.tag == "Bullet" && transform.position.y >= 15)
        {
            ScoreCounter.score += 20;
            Instantiate(floating20, transform.position, Quaternion.identity);
            Vector3 position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
            Instantiate(enemyParticles, position, Quaternion.identity);
            Destroy(gameObject);
        }
        else if (other.gameObject.tag == "Bullet" && transform.position.y >= 10)
        {
            ScoreCounter.score += 10;
            Instantiate(floating10, transform.position, Quaternion.identity);
            Vector3 position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
            Instantiate(enemyParticles, position, Quaternion.identity);
            Destroy(gameObject);
        }
        else if (other.gameObject.tag == "Bullet" && transform.position.y < 10)
        {
            ScoreCounter.score += 5;
            Instantiate(floating5, transform.position, Quaternion.identity);
            Vector3 position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
            Instantiate(enemyParticles, position, Quaternion.identity);
            Destroy(gameObject);
        }
        else if (other.gameObject.tag == "Player")
        {
            AbilityHandler.shieldDestroy = true;
            Destroy(other.gameObject);
            Destroy(gameObject);
            Instantiate(gameOver);
            pauseButton.SetActive(false);
            AbilityHandler.gameOverCoverCheck = true;
        }   
    }
}
