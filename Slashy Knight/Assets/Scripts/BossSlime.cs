using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSlime : MonoBehaviour
{
    private GameObject Knight;
    public GameObject slime;

    private BoxCollider2D hitBox;
    public float health = 50.0f;

    private Animator anim;
    private bool dead;
    public GameObject slimeDead;
    private bool spawned = false;

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
        if (health <= 25.0f && !spawned)
        {
            Instantiate(slime, gameObject.transform.position + new Vector3(0.25f, 0, 0), slime.transform.rotation);
            Instantiate(slime, gameObject.transform.position + new Vector3(-0.25f, 0, 0), slime.transform.rotation);
            spawned = true;
            gameObject.transform.Translate(new Vector3(0.1f, 8.185f, 0f) * Time.deltaTime);
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
