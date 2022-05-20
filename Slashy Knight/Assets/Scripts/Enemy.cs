using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Enemy : MonoBehaviour
{
    private GameObject Knight;

    public float health = 5.0f;

    private Animator anim;
    public bool dead;
    public GameObject slimeDead;

    public void Start()
    {
        dead = false;
        Knight = GameObject.Find("Knight");
        anim = GetComponent<Animator>();
    }
    public void Update()
    {
        if (!dead)
        {
            if (Vector2.Distance(Knight.transform.position, gameObject.transform.position) < 0.8f)
            {
                gameObject.transform.Translate((Knight.transform.position - gameObject.transform.position) * Time.deltaTime * 1.2f);
            }
        }
        if (health == 0.0f)
        {
            Instantiate(slimeDead, gameObject.transform.position, gameObject.transform.rotation);
            dead = true;
            anim.SetBool("IsDead", true);
            Destroy(gameObject);
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Sword")
        {
            health -= 1.0f;
        }
    }
}
