using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed = 5f; // Prêdkoœæ ruchu kulki
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    public GameController gameController;

    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
        mousePos.x = Mathf.Clamp(mousePos.x, minX, maxX);
        mousePos.y = Mathf.Clamp(mousePos.y, minY, maxY);

        transform.position = Vector2.MoveTowards(transform.position, mousePos, speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Good"))
        {
            Destroy(other.gameObject);
            gameController.AddPoints(1);
        }
        else if (other.CompareTag("Bad"))
        {
            Destroy(other.gameObject);
            gameController.AddPoints(-1);
        }
    }
}
