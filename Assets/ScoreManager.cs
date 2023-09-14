using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    private float score;
    public TextMeshProUGUI scoreUI;
    private float highscore;
    public TextMeshProUGUI highscoreUI;


    void Start()
    {
        highscore = PlayerPrefs.GetFloat("Highscore");
    }

    // Update is called once per frame
    void Update()
    {
        scoreUI.text = "Score: " + score;
        highscoreUI.text = "Record: " + highscore;

        if (score > highscore)
        {
            PlayerPrefs.SetFloat("Highscore", score);
        }
    }

    public void AddScore()
    {
        score++;
    }

    private void OnEnable()
    {
        CactusScript.scoreevent += AddScore;
    }
    private void OnDisable()
    {
        CactusScript.scoreevent -= AddScore;
    }
}
