using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI HighScoreText;
    [SerializeField] TextMeshProUGUI ScoreText;

    public static int score;
    int highscore;

    void Start()
    {
        score = 0;
    }


    void Update()
    {
        highscore = score;
        ScoreText.text = "SCORE: " + highscore.ToString();
        if (PlayerPrefs.GetInt("score") <= highscore)
            PlayerPrefs.SetInt("score", highscore);

        HighScoreText.text = "HIGHSCORE: " + PlayerPrefs.GetInt("score").ToString();
    }
}
