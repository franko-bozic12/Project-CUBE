using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody rB;
    public float speed;
    
    void Start()
    {
        rB.velocity = transform.right * -1 * speed * Time.deltaTime;    // POstavlja brzinu metka pri pokretanju
    }

    void Update()
    {
        //Provjera granice metka
        if(transform.position.y >= 20 || transform.position.x <= -7 || transform.position.x >= 7)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy" && AbilityHandler.piercerCheck == false)    //Provjerava kolizije s neprijateljem
            Destroy(gameObject);
    }
}
