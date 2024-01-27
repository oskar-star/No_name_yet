using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] float speed = 5f; // Prêdkoœæ ruchu kulki
    [SerializeField] float minX;
    [SerializeField] float maxX;
    [SerializeField] float minY;
    [SerializeField] float maxY;

    void Start()
    {
        
       
    }

    void Update()
    {
        // Pobierz pozycjê myszy w jednostkach kamery
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));


        
        // Ogranicz ruch kulki do osi X i Y
        mousePos.x = Mathf.Clamp(mousePos.x, minX, maxX);
        mousePos.y = Mathf.Clamp(mousePos.y, minY, maxY);

        // Ustaw now¹ pozycjê kulki
        transform.position = Vector2.MoveTowards(transform.position, mousePos, speed * Time.deltaTime);
    }
}
