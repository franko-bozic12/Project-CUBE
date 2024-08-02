using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Skripta funkcionira isto kao Enemy skripta

public class EnemyElectricity : MonoBehaviour
{
    public Transform player;
    public static float speed = 1;

    void Update()
    {
        if (Abilities.destroyer == true)
        {
            Destroy(gameObject);
        }
        transform.LookAt(player);
        transform.position += transform.forward * speed * Time.deltaTime;
        if (transform.position.y <= 2)
            Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            Destroy(gameObject);
        }
        else if (other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
