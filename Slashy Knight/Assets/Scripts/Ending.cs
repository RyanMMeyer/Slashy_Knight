using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour
{
    public Button button;

    public void Start()
    {
        button = GetComponent<Button>();
    }
    public void Restart()
    {
        SceneManager.MoveGameObjectToScene(GameObject.Find("Sword Controller"), SceneManager.GetActiveScene());
        SceneManager.MoveGameObjectToScene(GameObject.Find("Enemy Spawner"), SceneManager.GetActiveScene());
        SceneManager.MoveGameObjectToScene(GameObject.Find("Screen"), SceneManager.GetActiveScene());
        SceneManager.MoveGameObjectToScene(GameObject.Find("Knight"), SceneManager.GetActiveScene());
        SceneManager.LoadScene(0);
    }
}
