using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManagerScript : MonoBehaviour {
    public int cur_coins = 0;
    private int max_coins = 0;
    public Text coinsLeft;
    public GameObject Door;
    public float timeLeft = 30.0f;
    public Text timerText;
    public float timer = 99;

    // Use this for initialization
    void Start () {
        Door.SetActive(false);
        max_coins = cur_coins;
        UpdateUI();
    }

    public void UpdateUI()
    {
        if (cur_coins > 0)
        {
            coinsLeft.text = "Coins Left: " + cur_coins.ToString() + "/" + max_coins.ToString();
        }
        else if(cur_coins <= 0)
        {
            Door.SetActive(true);
            coinsLeft.text = "Coins Left: " + cur_coins.ToString() + "/" + max_coins.ToString();
        }
    }
}
