using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Prefs : MonoBehaviour
{
    public Text resultText;
    private float result;
    void Start()
    {
        result = PlayerPrefs.GetFloat("HighScore");
        PlayerPrefs.SetFloat("HighScore", result);
        resultText.text = "Coins. " + result;
    }
    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }
}
