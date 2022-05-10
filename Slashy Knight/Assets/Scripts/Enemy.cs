using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Enemy : MonoBehaviour
{
    private bool chasting;
    private bool collidingWithPlayer;
    private GameObject Knight;
    private Vector3 startingPosition;

    private BoxCollider2D hitBox;
    public float health = 5.0f;

    private Animator anim;
    private bool dead;
    public GameObject slimeDead;
    public GameObject slime;
    
    public void Start()
    {
        slimeDead.SetActive(false);
        dead = false;
        Knight = GameObject.Find("Knight");
        anim = GetComponent<Animator>();
    }
    public void Update()
    {
        if (dead == false)
        {
            if (Vector2.Distance(Knight.transform.position, gameObject.transform.position) < 0.8f)
            {
                gameObject.transform.Translate((Knight.transform.position - gameObject.transform.position) * Time.deltaTime * 1.2f);
            }
        }
        if (health == 0.0f)
        {
            slimeDead.transform.position = gameObject.transform.position;
            dead = true;
            anim.SetBool("IsDead", true);
            slimeDead.SetActive(true);
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
