using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuFade : MonoBehaviour
{
    public GameObject fade;
    public static bool play;

    void Start()
    {
        play = false;
    }

    void Update()
    {
        if(play == true)
        {
            Instantiate(fade);
            Invoke("loadScene", 1);
            play = false;
        }
    }

    void loadScene()
    {
        SceneManager.LoadScene(1);  //Pokretanje igre
    }
}
