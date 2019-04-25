using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WriteScore : MonoBehaviour
{
    private Text scoreText;
    void Start()
    {
        scoreText = GetComponent<Text>();
    }

    void Update()
    {
        scoreText.text = "Score: " + ScoreControl.score.ToString();
    }
}
