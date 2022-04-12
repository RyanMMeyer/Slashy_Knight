using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    public int iLevelToLoad;
    public string sLevelToLoad;
    public bool levelInt = false;
 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        GameObject collisionGameObject = collision.gameObject;
        if (collisionGameObject.name == "Knight")
        {
            LoadScene();
        }
    }
    void LoadScene()
    {
        if (levelInt)
        {
            SceneManager.LoadScene(iLevelToLoad);
        }
        else
        {
            SceneManager.LoadScene(sLevelToLoad);
        }
    }
}
