using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemySpawner : MonoBehaviour
{
    public GameObject slime;
    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("OnSceneLoaded: " + scene.name);

        if (scene.name == "Tutorial")
        {
            Instantiate(slime, new Vector2(2.8f, 2.7f), slime.transform.rotation);
        }
        if (scene.name == "Level1")
        {
            Instantiate(slime, new Vector3(2.2f, 2.7f, 0f), slime.transform.rotation);
            Instantiate(slime, new Vector3(-0.65f, 2.7f, 0f), slime.transform.rotation);
            Instantiate(slime, new Vector3(2.2f, 4.5f, 0f), slime.transform.rotation);
            Instantiate(slime, new Vector3(-0.65f, 4.5f, 0f), slime.transform.rotation);
        }
        if (scene.name == "Level2")
        {
            Instantiate(slime, new Vector2(0.07f, 3.9f), slime.transform.rotation);
        }
        if (scene.name == "Level3")
        {
            Instantiate(slime, new Vector2(1.82f, 1.82f), slime.transform.rotation);
            Instantiate(slime, new Vector2(-1.6f, 1.82f), slime.transform.rotation);
            Instantiate(slime, new Vector2(-1.56f, -1.56f), slime.transform.rotation);
            Instantiate(slime, new Vector2(1.79f, -1.56f), slime.transform.rotation);
            Instantiate(slime, new Vector2(0.07f, 4f), slime.transform.rotation);
            Instantiate(slime, new Vector2(0.07f, -3.5f), slime.transform.rotation);
        }
        
    }
    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
