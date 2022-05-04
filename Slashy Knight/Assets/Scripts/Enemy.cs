using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private bool chasting;
    private bool collidingWithPlayer;
    public GameObject Knight;
    private Vector3 startingPosition;

    private BoxCollider2D hitBox;
    public float health = 5.0f;
    public void Update()
    {
        if (Vector2.Distance(Knight.transform.position, gameObject.transform.position) < 0.8f)
        {
            gameObject.transform.Translate((Knight.transform.position - gameObject.transform.position) * Time.deltaTime * 1.2f);
        }
        if (health == 0.0f)
        {
            gameObject.SetActive(false);
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "Sword")
        {
            health -= 1.0f;
        }
    }
}
