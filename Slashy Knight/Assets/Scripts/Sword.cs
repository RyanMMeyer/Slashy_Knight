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
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        mousePosition = new Vector3(mousePosition.x, mousePosition.y, 0);
        newVector = (mousePosition - Knight.transform.position).normalized * 0.13f;
        newPos = Knight.transform.position + newVector;
        transform.position = newPos;
        transform.rotation = Quaternion.LookRotation(newVector, Vector3.up);
    

    }
}
