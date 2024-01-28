using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject goodPrefab;
    public GameObject badPrefab;
    public Text scoreText;

    private int currentScore = 0;

    public float goodSpawnInterval = 2f;
    public float badSpawnInterval = 3f;

    private void Start()
    {
        ScoreManager.OnScoreChanged += UpdateScoreText;
        ScoreManager.ResetScore();
        InvokeRepeating("SpawnGoodObjects", 0f, goodSpawnInterval);
        InvokeRepeating("SpawnBadObjects", 0f, badSpawnInterval);
    }

    private void SpawnGoodObjects()
    {
        float randomX = Random.Range(GetMinX(), GetMaxX());
        Instantiate(goodPrefab, new Vector3(randomX, GetSpawnY(), 0f), Quaternion.identity);
    }

    private void SpawnBadObjects()
    {
        float randomX = Random.Range(GetMinX(), GetMaxX());
        Instantiate(badPrefab, new Vector3(randomX, GetSpawnY(), 0f), Quaternion.identity);
    }

    private float GetSpawnY()
    {
        return Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 1, 0)).y;
    }

    private float GetMinX()
    {
        return Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).x;
    }

    private float GetMaxX()
    {
        return Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0)).x;
    }

    public void RestartGame()
    {
        ScoreManager.ResetScore();
        currentScore = 0;
    }

    private void UpdateScoreText(int newScore)
    {
        currentScore = newScore;
        if (scoreText != null)
        {
            scoreText.text = "Wynik: " + currentScore.ToString();
        }
    }

    public void AddPoints(int points)
    {
        currentScore += points;
        ScoreManager.AddPoints(points);
    }
}
