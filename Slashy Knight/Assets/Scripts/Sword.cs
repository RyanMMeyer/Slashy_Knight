using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Sword : MonoBehaviour
{
    public GameObject Knight;
    public Vector3 mousePosition;
    public float moveSpeed = 1.0f;
    Rigidbody2D rb;
    Vector2 position = new Vector2(0.8f, 0.5f);
    Vector2 lookDirection;
    float lookAngle;
    public Vector3 newVector;
    Vector3 newPos;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        //position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
        newVector = (mousePosition - Knight.transform.position);
        newPos = Knight.transform.position + newVector;
        transform.position = newPos;
        //rb.MovePosition(newPos);
    }

    private void FixedUpdate()
    {
         //rb.MovePosition(newPos);
    }

}
