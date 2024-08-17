using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class apple : MonoBehaviour
{
    [SerializeField] private snake_head _snake;

    [SerializeField] private float _minX, _maxX, _minY, _maxY;

    
    void Start()
    {
        RandomApplePosition();
    }


    private void RandomApplePosition()
{
    Vector2 newPosition = Vector2.zero;
    bool validPosition = false;

    // Yeni bir konum belirleyene kadar geçerli bir konum bulana kadar döngüde kal
    while (!validPosition)
    {
        newPosition = new Vector2(
            Mathf.Round(Random.Range(_minX, _maxX)) + 0.5f,
            Mathf.Round(Random.Range(_minY, _maxY)) + 0.5f
        );

        // Yeni konumu kontrol et, çakýþma yoksa geçerli bir pozisyon olarak iþaretle
        Collider2D[] colliders = Physics2D.OverlapCircleAll(newPosition, 0.1f);
        validPosition = colliders.Length == 0;
    }

    // Yeni geçerli pozisyona elmayý taþý
    transform.position = newPosition;
}
private void OnTriggerEnter2D(Collider2D other)
{
    if (other.gameObject.CompareTag("head"))
    {
        RandomApplePosition();
        _snake.CreateSegment();
    }
}
}
