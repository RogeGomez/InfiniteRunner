using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    // TODO en este script va a estar
    // TODO -Contador -Timer.
    // TODO al reiniciar el juego se tiene que reiniciar el contador y el timer. 


    [SerializeField] private TextMeshProUGUI counterText;
    private float counter;

    [SerializeField] private TextMeshProUGUI scoreText;
    public int score;

    private void Start()
    {
        UpdateScore();
    }

    private void Update()
    {
        UpdateTimer();
        scoreText.text = "Score: " + score;
    }

    public void UpdateScore()
    {
        score = 0;
        scoreText.text = "Score: " + score;
    }

    private void UpdateTimer()
    {
        counter += Time.deltaTime;
        counterText.text = counter.ToString("0");
    }
}
