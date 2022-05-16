using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Button button;
    public bool dead;

    public void Start()
    {
        button = GetComponent<Button>();
    }
    public void Restart()
    {
        SceneManager.LoadScene("Start Screen");
    }
}
