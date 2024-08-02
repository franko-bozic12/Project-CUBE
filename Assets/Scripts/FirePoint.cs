using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePoint : MonoBehaviour
{
    public Transform firePoint;
    public BoxCollider bC;
    public GameObject bullet;
    public GameObject bulletClip1;
    public GameObject bulletClip2;
    public GameObject bulletClip3;
    public LayerMask groundLayer;
    public static int startingBullets;

    private bool groundCheck;
    private int bulletCount;

    void Start() //Provjera pocetnog broja metaka
    {
        startingBullets = 2;
        bulletCount = startingBullets;
        if(startingBullets == 1)
            bulletClip1.SetActive(true);
        else if(startingBullets == 2)
        {
            bulletClip1.SetActive(true);
            bulletClip2.SetActive(true);
        }
        else if(startingBullets == 3)
        {
            bulletClip1.SetActive(true);
            bulletClip2.SetActive(true);
            bulletClip3.SetActive(true);
        }
    }

    void Update()
    {
        groundCheck = Physics.Raycast(bC.bounds.center, Vector3.down, bC.bounds.extents.y + 0.01f, groundLayer);    //Provjera ako Player dira tlo

        //Provjera za pucanje metaka
        if(groundCheck == false && bulletCount > 0 && Input.GetKeyDown(KeyCode.Mouse0) == true && PauseButton.pauseCheck == false && Input.mousePosition.y < Screen.height * 0.9 && (Input.mousePosition.y > Screen.height * 0.25 || Input.mousePosition.x < Screen.width * 0.72))
        {
            Instantiate(bullet, firePoint.position, firePoint.rotation);
            if(bulletCount == 3)
                bulletClip3.SetActive(false);
            else if(bulletCount == 2)
                bulletClip2.SetActive(false);
            else if(bulletCount == 1)
                bulletClip1.SetActive(false);
            bulletCount--;
        }

        //Prebrojavanje metaka
        if(groundCheck == true)
        {
            if(startingBullets == 3 && bulletCount == 2)
            {
                bulletClip3.SetActive(true);
            }
            else if(startingBullets == 3 && bulletCount == 1)
            {
                bulletClip3.SetActive(true);
                bulletClip2.SetActive(true);
            }
            else if(startingBullets == 3 && bulletCount == 0)
            {
                bulletClip3.SetActive(true);
                bulletClip2.SetActive(true);
                bulletClip1.SetActive(true);
            }
            else if(startingBullets == 2 && bulletCount == 1)
            {
                bulletClip2.SetActive(true);
            }
            else if(startingBullets == 2 && bulletCount == 0)
            {
                bulletClip2.SetActive(true);
                bulletClip1.SetActive(true);
            }
            else if(startingBullets == 1 && bulletCount == 0)
                bulletClip1.SetActive(true);
            bulletCount = startingBullets;
        }
    }
}
