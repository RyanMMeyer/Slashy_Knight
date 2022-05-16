using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    //private GameOver gameOver;
    public float currentHealth { get; private set; }

    private void Awake()
    {
        currentHealth = startingHealth;
        //gameOver = GetComponent<GameOver>();
    }
    void Update()
    {
        //if (gameOver.dead)
        //{
        //    currentHealth = startingHealth;
        //}
    }
    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);
    }
}

