using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customize : MonoBehaviour
{
    public GameObject skin1;
    public GameObject skin2;
    public GameObject skin3;
    public GameObject skin4;
    public static int skinCheck = 1;

    void Start()
    {
        if (PlayerPrefs.GetInt("Customization", 0) == 1)
        {
            skin1.transform.position = new Vector3(0, -2, -17);
            skin2.transform.position = new Vector3(15, -2, -17);
            skin3.transform.position = new Vector3(30, -2, -17);
            skin4.transform.position = new Vector3(45, -2, -17);
            skinCheck = 1;
        }
        else if (PlayerPrefs.GetInt("Customization", 0) == 2)
        {
            skin1.transform.position = new Vector3(-15, -2, -17);
            skin2.transform.position = new Vector3(0, -2, -17);
            skin3.transform.position = new Vector3(15, -2, -17);
            skin4.transform.position = new Vector3(30, -2, -17);
            skinCheck = 2;
        }
        else if (PlayerPrefs.GetInt("Customization", 0) == 3)
        {
            skin1.transform.position = new Vector3(-30, -2, -17);
            skin2.transform.position = new Vector3(-15, -2, -17);
            skin3.transform.position = new Vector3(0, -2, -17);
            skin4.transform.position = new Vector3(15, -2, -17);
            skinCheck = 3;
        }
        else if (PlayerPrefs.GetInt("Customization", 0) == 4)
        {
            skin1.transform.position = new Vector3(-45, -2, -17);
            skin2.transform.position = new Vector3(-30, -2, -17);
            skin3.transform.position = new Vector3(-15, -2, -17);
            skin4.transform.position = new Vector3(0, -2, -17);
            skinCheck = 4;
        }
    }

    void Update()
    {
        if(skinCheck == 1)
        {
            skin1.transform.position = new Vector3(0, -2, -17);
            skin2.transform.position = new Vector3(15, -2, -17);
            skin3.transform.position = new Vector3(30, -2, -17);
            skin4.transform.position = new Vector3(45, -2, -17);
            PlayerPrefs.SetInt("Customization", skinCheck);
        }
        else if(skinCheck == 2)
        {
            skin1.transform.position = new Vector3(-15, -2, -17);
            skin2.transform.position = new Vector3(0, -2, -17);
            skin3.transform.position = new Vector3(15, -2, -17);
            skin4.transform.position = new Vector3(30, -2, -17);
            PlayerPrefs.SetInt("Customization", skinCheck);
        }
        else if (skinCheck == 3)
        {
            skin1.transform.position = new Vector3(-30, -2, -17);
            skin2.transform.position = new Vector3(-15, -2, -17);
            skin3.transform.position = new Vector3(0, -2, -17);
            skin4.transform.position = new Vector3(15, -2, -17);
            PlayerPrefs.SetInt("Customization", skinCheck);
        }
        else if (skinCheck == 4)
        {
            skin1.transform.position = new Vector3(-45, -2, -17);
            skin2.transform.position = new Vector3(-30, -2, -17);
            skin3.transform.position = new Vector3(-15, -2, -17);
            skin4.transform.position = new Vector3(0, -2, -17);
            PlayerPrefs.SetInt("Customization", skinCheck);
        }
    }
}
