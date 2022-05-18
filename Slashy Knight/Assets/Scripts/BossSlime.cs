using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.SceneManagement;

public class BossSlime : MonoBehaviour
{
    private GameObject Knight;
    public GameObject slime;

    private BoxCollider2D hitBox;
    public float health = 50.0f;

    private Animator anim;
    private bool dead;
    public GameObject slimeDead;
    private bool spawned1 = false;
    private bool spawned2 = false;
    public GameObject princess;

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
            if (Vector2.Distance(Knight.transform.position, gameObject.transform.position) < 1.5f)
            {
                gameObject.transform.Translate((Knight.transform.position - gameObject.transform.position) * Time.deltaTime * 1.2f);
            }
        }
        if (health <= 50.0f && !spawned1)
        {
            Instantiate(slime, gameObject.transform.position + new Vector3(0.25f, 0, 0), slime.transform.rotation);
            Instantiate(slime, gameObject.transform.position + new Vector3(-0.25f, 0, 0), slime.transform.rotation);
            spawned1 = true;
            gameObject.transform.Translate(new Vector3(0.1f, 8.185f, 0f) * Time.deltaTime);
        }
        if (health <= 25.0f && !spawned2)
        {
            Instantiate(slime, gameObject.transform.position + new Vector3(0.25f, 0, 0), slime.transform.rotation);
            Instantiate(slime, gameObject.transform.position + new Vector3(-0.25f, 0, 0), slime.transform.rotation);
            Instantiate(slime, gameObject.transform.position + new Vector3(0, 0.25f, 0), slime.transform.rotation);
            spawned2 = true;
            gameObject.transform.Translate(new Vector3(0.1f, 8.185f, 0f) * Time.deltaTime);
        }
        if (health <= 0.0f)
        {
            anim.SetBool("IsDead", true);
            Instantiate(slimeDead, gameObject.transform.position, gameObject.transform.rotation);
            Instantiate(princess, gameObject.transform.position, gameObject.transform.rotation);
            gameObject.SetActive(false);
            Invoke("Ending", 3.0f);
        }
    }

    void Ending()
    {
        Debug.Log("working");
        SceneManager.LoadScene("Ending");
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
