using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Sword : MonoBehaviour
{
    public GameObject Knight;
    Vector3 mousePosition;
    public float moveSpeed = 1.0f;
    Rigidbody2D rb;
    Vector2 position = new Vector2(0.8f, 0.5f);
    Vector2 lookDirection;
    float lookAngle;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
        
    }

    private void FixedUpdate()
    {
        if (Vector2.Distance(Knight.transform.position, position) <= 0.3f)
        {
            rb.MovePosition(position);
        }

    }

}
