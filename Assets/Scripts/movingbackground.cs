using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBackground : MonoBehaviour
{
    public float speed = 1.0f;
    public GameController gameController; // Upewnij siê, ¿e ten obiekt jest przypisany w inspektorze Unity

    void Start()
    {
        float startPositionX = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).x; // Lewy kraniec ekranu
        transform.position = new Vector2(startPositionX, transform.position.y);
    }

    void Update()
    {
        MoveBackground();
    }

    void MoveBackground()
    {
        float newPositionX = transform.position.x - speed * Time.deltaTime;
        transform.position = new Vector2(newPositionX, transform.position.y);

        if (transform.position.x < -11)
        {
            RepositionBackground();
        }
    }

    void RepositionBackground()
    {
        float offset = 11 * 2; // Wartoœæ dwa razy wiêksza ni¿ szerokoœæ obiektu t³a

        Vector2 newPosition = new Vector2(transform.position.x + offset, transform.position.y);
        transform.position = newPosition;
    }

    void SpawnObjects()
    {
        if (gameController != null)
        {
            float spawnY = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 1, 0)).y; // Y-coordinate pod górnym krawêdzi¹ ekranu
            Instantiate(gameController.goodPrefab, new Vector3(Random.Range(-5f, 5f), spawnY, 0f), Quaternion.identity);
            Instantiate(gameController.badPrefab, new Vector3(Random.Range(-5f, 5f), spawnY, 0f), Quaternion.identity);
        }
        else
        {
            Debug.LogError("gameController is not assigned in MovingBackground script.");
        }
    }
}
