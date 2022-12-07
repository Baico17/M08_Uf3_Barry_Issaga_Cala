using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public Text score, time;
    
    public float startTime = 200.0f;

    public GameObject gameOver;
    public GameObject wellDone;
    public List<GameObject> coin;
    //public List<GameObject> bigCoin;

    private float currentTime;
    private int scoreCounter, timeCounter;

    void Start()
    {
        currentTime = startTime;
        gameOver.SetActive(false);
        wellDone.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= Time.deltaTime;
        timeCounter = (int)currentTime;

        if (currentTime <=0.0f)
        {
            timeCounter = 0;
            gameOver.SetActive(true);

            diseableCoins();

            if(Input.touchCount == 2)
            {
                SceneManager.LoadScene(0);
            }

        }

        if(scoreCounter >= 110)
        {
            wellDone.SetActive(true);

            if (Input.touchCount == 2)
            {
                SceneManager.LoadScene(0);
            }
        }

        score.text = "Score:" + scoreCounter;
        time.text = "Time:" + timeCounter;
    }

    public void IncreaseScore(int points)
    {
        scoreCounter += points;
    }

    public void diseableCoins()
    {
        for (int i = 0; i < coin.Count; i++)
        {
            Destroy(coin[i]);
        }
       
    }
}
