using UnityEngine;
using UnityEngine.UI;
using System;

public class ScoreManager : MonoBehaviour
{
    public static event Action<int> OnScoreChanged; // Dodaj to zdarzenie

    public static int score = 0;

    private void Start()
    {
        score = 0;
        UpdateScoreText();
    }

    public static void AddPoints(int points)
    {
        score += points;
        UpdateScoreText();
    }

    public static void ResetScore()
    {
        score = 0;
        UpdateScoreText();
    }

    private static void UpdateScoreText()
    {
        OnScoreChanged?.Invoke(score);
    }
}
