using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBackground : MonoBehaviour
{
    public float speed = 1.0f;  // Prêdkoœæ ruchu t³a

    void Update()
    {
        MoveBackground();
    }

    void MoveBackground()
    {
        // Przesuñ obiekt w lewo (lub innym kierunku)
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        // Jeœli obiekt jest wystarczaj¹co daleko w lewo, przenieœ go z powrotem na prawo
        if (transform.position.x < -11)
        {
            RepositionBackground();
        }
    }

    void RepositionBackground()
    {
        // Okreœl now¹ pozycjê obiektu na prawo od ekranu
        Vector2 newPosition = new Vector2(13, 0);

        // Przesuñ obiekt na now¹ pozycjê
        transform.position = newPosition;
    }
}
