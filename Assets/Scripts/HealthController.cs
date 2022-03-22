using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthController : MonoBehaviour
{
    public int playerHealth;
    [SerializeField] private Image[] hearts;
    public Text coinText, highScoreCoin;
    public float currentCoins = 0;
    public float highScore;
    public GameObject prefabCoin;
    private float randomPosX;
    private float randomPositionXOne;
    private float randomPositionXTwo;
    void Start()
    {
        randomPosX = Random.Range(-3.5f, 3.5f);
        randomPositionXOne = Random.Range(1.5f, 3.5f);
        randomPositionXTwo = Random.Range(-1.5f, -3.5f);
        for (int i = 2; i < 8; i+=2)
        {
            Instantiate(prefabCoin, new Vector3(randomPosX, 1, i), prefabCoin.transform.rotation);
        }
        for (int i = 12; i < 16; i += 2)
        {
            Instantiate(prefabCoin, new Vector3(randomPositionXOne, 1, i), prefabCoin.transform.rotation);
        }
        for (int i = 18; i < 32; i += 2)
        {
            Instantiate(prefabCoin, new Vector3(randomPositionXTwo, 1, i), prefabCoin.transform.rotation);
        }
        for (int i = 30; i < 36; i += 2)
        {
            Instantiate(prefabCoin, new Vector3(randomPositionXOne, 1, i), prefabCoin.transform.rotation);
        }
        for (int i = 38; i < 48; i += 2)
        {
            Instantiate(prefabCoin, new Vector3(randomPositionXOne, 1, i), prefabCoin.transform.rotation);
        }
        for (int i = 50; i < 66; i += 2)
        {
            Instantiate(prefabCoin, new Vector3(randomPosX, 1, i), prefabCoin.transform.rotation);
        }
        for (int i = 70; i < 88; i += 2)
        {
            Instantiate(prefabCoin, new Vector3(randomPositionXOne, 1, i), prefabCoin.transform.rotation);
        }
        for (int i = 92; i < 100; i += 2)
        {
            Instantiate(prefabCoin, new Vector3(randomPositionXTwo, 1, i), prefabCoin.transform.rotation);
        }
        for (int i = 106; i < 110; i += 2)
        {
            Instantiate(prefabCoin, new Vector3(randomPositionXOne, 1, i), prefabCoin.transform.rotation);
        }
        if (PlayerPrefs.GetFloat("HighScore") != null)
        {
            highScore = PlayerPrefs.GetFloat("HighScore");
        }
        coinText.text = "Coins: " + Mathf.Round(currentCoins);
    }
    private void Update ()
    {
        UpdateHealth();
        if (this.gameObject.transform.position.z > Level.forwardSide2)
        {
            SceneManager.LoadScene("Result");
        }
        if (currentCoins > highScore)
        {
            highScore = currentCoins;
            PlayerPrefs.SetFloat("HighScore", highScore);
        }
        highScoreCoin.text = "High Score: " + Mathf.Round(highScore);
    }
    public void UpdateHealth()
    {
        if (playerHealth == 0)
        {
            playerHealth = 3;
            SceneManager.LoadScene("Result");
            //PlayerPrefs.DeleteAll();
        }
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < playerHealth)
            {
                hearts[i].color = Color.red;
            }
            else
            {
                hearts[i].color = Color.black;
            }
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin")
        {
            Destroy(other.gameObject);
            currentCoins += 1;
            //PlayerPrefs.SetInt("Coin", currentCoins);
            coinText.text = "Coins :" + currentCoins;
        }
    }
}
