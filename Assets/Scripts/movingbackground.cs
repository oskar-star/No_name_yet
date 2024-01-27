using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBackground : MonoBehaviour
{
    public float speed = 1.0f;  // Pr�dko�� ruchu t�a

    void Update()
    {
        MoveBackground();
    }

    void MoveBackground()
    {
        // Przesu� obiekt w lewo (lub innym kierunku)
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        // Je�li obiekt jest wystarczaj�co daleko w lewo, przenie� go z powrotem na prawo
        if (transform.position.x < -11)
        {
            RepositionBackground();
        }
    }

    void RepositionBackground()
    {
        // Okre�l now� pozycj� obiektu na prawo od ekranu
        Vector2 newPosition = new Vector2(13, 0);

        // Przesu� obiekt na now� pozycj�
        transform.position = newPosition;
    }
}
