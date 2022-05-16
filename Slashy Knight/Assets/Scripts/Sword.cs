using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Sword : MonoBehaviour
{
    public GameObject Knight;
    public Vector3 mousePosition;
    Vector2 position = new Vector2(0.8f, 0.5f);
    public Vector3 newVector;
    Vector3 newPos;
    private Health health;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        health = GetComponent<Health>();
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
    //    if (health.currentHealth == 0)
    //    {
    //        Destroy(gameObject);
    //    }
    }
 }
