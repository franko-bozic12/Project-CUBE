using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public Text highScore;
    
    void Start()
    {
        highScore.text = "High Score: " + PlayerPrefs.GetInt("HighScore", 0).ToString();    //Zapisivanje High Score-a
    }
}
