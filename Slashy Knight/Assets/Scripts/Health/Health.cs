using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    private GameObject screen;
    public float currentHealth { get; private set; }

    private void Awake()
    {
        currentHealth = startingHealth;
        screen = GameObject.Find("Healthbar");
    }
    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);
        if (currentHealth <= 0.0f)
        {
            screen.SetActive(false);
        }
    }
}

