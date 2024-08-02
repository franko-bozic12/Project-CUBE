using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCustomization : MonoBehaviour
{
    public GameObject skin1;
    public GameObject skin2;
    public GameObject skin3;
    public GameObject skin4;

    void Start()
    {
        if(Customize.skinCheck == 1)
        {
            skin1.SetActive(true);
            skin2.SetActive(false);
            skin3.SetActive(false);
            skin4.SetActive(false);
        }
        else if(Customize.skinCheck == 2)
        {
            skin1.SetActive(false);
            skin2.SetActive(true);
            skin3.SetActive(false);
            skin4.SetActive(false);
        }
        else if (Customize.skinCheck == 3)
        {
            skin1.SetActive(false);
            skin2.SetActive(false);
            skin3.SetActive(true);
            skin4.SetActive(false);
        }
        else if (Customize.skinCheck == 4)
        {
            skin1.SetActive(false);
            skin2.SetActive(false);
            skin3.SetActive(false);
            skin4.SetActive(true);
        }
    }
}
