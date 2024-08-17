
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class snake_head : MonoBehaviour
{
    public scoreManager cm;
    public gameover gameover;
    private Vector2 _direction;
    [SerializeField] private GameObject _segmentPrefab;
    private List<GameObject> _segments = new List<GameObject>();

    public float moveSpeed = 5; // Hareket hýzýný belirler

    void Start()
    {
        Reset();
        InitializeSegments();
    }

    void Update()
    {
        GetUserInput();
    }

    private void FixedUpdate()
    {
        MoveSnake();
    }

    private void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void Reset()
    {
        _direction = Vector2.right;
        Time.timeScale = 1f;
    }
    
    private void InitializeSegments()
    {
        _segments.Clear();
        _segments.Add(gameObject);

        for (int i = 0; i < 1; i++)
        {
            CreateSegment();
            _segments[i].transform.position = _segments[i].transform.position + new Vector3(_direction.x, _direction.y, 0) * -1;
        }
    }

    private void MoveSegment()
    {
        for (int i = _segments.Count - 1; i > 0; i--)
        {
            _segments[i].transform.position = _segments[i - 1].transform.position;
        }
    }

    public void CreateSegment()
    {
        GameObject newSegment = Instantiate(_segmentPrefab);
        Vector2 offset = _direction * 500;
        newSegment.transform.position = _segments[0].transform.position + new Vector3(offset.x, offset.y, 0) - new Vector3(_direction.x, _direction.y, 0);
        _segments.Insert(1, newSegment);
    }
    
    /*
    public float segmentSpacing = 10; // Segmentler arasýndaki mesafe

    private void InitializeSegments()
    {
        _segments.Clear();
        _segments.Add(gameObject);

        // Ýlk segmenti oluþturup baþlangýç pozisyonunu ayarlýyoruz
        for (int i = 0; i < 1; i++)
        {
            CreateSegment();
            _segments[i+1].transform.position = _segments[i].transform.position - new Vector3(_direction.x, _direction.y, 0) * segmentSpacing;
        }
    }

    private void MoveSegment()
    {
        // Her segmenti bir önceki segmentin pozisyonuna taþýyoruz
        for (int i = _segments.Count - 1; i > 0; i--)
        {
            _segments[i].transform.position = _segments[i - 1].transform.position;
        }
    }

    public void CreateSegment()
    {
        // Yeni segmenti yaratýyoruz
        GameObject newSegment = Instantiate(_segmentPrefab);

        // Yeni segmenti, baþ segmentten belirli bir mesafe uzaða yerleþtiriyoruz
        Vector3 offset = new Vector3(_direction.x, _direction.y, 0) * segmentSpacing;
        newSegment.transform.position = _segments[0].transform.position - offset;

        // Yeni segmenti listenin en sonuna ekliyoruz
        _segments.Add(newSegment);
    }
    */
    private void MoveSnake()
    {
        Vector3 newPosition = transform.position + (Vector3)_direction.normalized*moveSpeed;
        transform.position = newPosition;

        // Rotate the head of the snake
        float angle = GetAngleFromDirection(_direction);
        transform.rotation = Quaternion.Euler(0, 0, angle);

        Vector3 lastPos = transform.position;

        for (int i = 0; i < _segments.Count; i++)
        {
            Vector3 tempPos = _segments[i].transform.position;
            _segments[i].transform.position = lastPos;
            lastPos = tempPos;

            // Rotate the segment
            _segments[i].transform.rotation = Quaternion.Euler(0, 0, -angle);
        }
    }

    private float GetAngleFromDirection(Vector2 direction)
    {
        if (direction == Vector2.up)
            return 0;
        else if (direction == Vector2.down)
            return 180;
        else if (direction == Vector2.right)
            return 90;
        else if (direction == Vector2.left)
            return -90;

        return 0;
    }

    private void GetUserInput()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            _direction = Vector2.up;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            _direction = Vector2.down;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            _direction = Vector2.right;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            _direction = Vector2.left;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("wall"))
        {
            Time.timeScale = 0;

            gameover.gameOver();
        }
        if (other.gameObject.CompareTag("apple"))
        {
            cm.appleCount++;
        }

    }
}


