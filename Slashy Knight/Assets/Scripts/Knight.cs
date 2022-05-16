using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Knight : MonoBehaviour
{
    private RaycastHit2D hit;
    private Vector3 moveDelta;
    private BoxCollider2D boxCollider;
    private Health health;
    private bool dead;
    

    // Start is called before the first frame update
    void Awake()
    {
        dead = false;
        boxCollider = GetComponent<BoxCollider2D>();
        DontDestroyOnLoad(gameObject);
        health = GetComponent<Health>();
    }
    private void OnLevelWasLoaded(int level)
    {
        FindStartPos();
    }
    void FindStartPos()
    {
        transform.position = GameObject.FindWithTag("StartPos").transform.position;
    }

    private void FixedUpdate()
    {
        if (!dead)
        {
            float x = Input.GetAxisRaw("Horizontal");
            float y = Input.GetAxisRaw("Vertical");

            moveDelta = new Vector3(x, y, 0);

            hit = Physics2D.BoxCast(transform.position, boxCollider.size, 0, new Vector2(0, moveDelta.y), Mathf.Abs(moveDelta.y * Time.deltaTime), LayerMask.GetMask("Actor", "Blocking"));
            if (hit.collider == null)
            {
                transform.Translate(0, moveDelta.y * Time.deltaTime, 0);
            }

            hit = Physics2D.BoxCast(transform.position, boxCollider.size, 0, new Vector2(moveDelta.x, 0), Mathf.Abs(moveDelta.x * Time.deltaTime), LayerMask.GetMask("Actor", "Blocking"));
            if (hit.collider == null)
            {
                transform.Translate(moveDelta.x * Time.deltaTime, 0, 0);
            }
        }
        if (health.currentHealth == 0 && !dead)
        {
            dead = true;
            SceneManager.LoadScene("Game Over");
            Destroy(gameObject);
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Slime")
        {
            health.TakeDamage(1);
        }
    }
}
