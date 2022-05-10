using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeSpawner : MonoBehaviour
{
    public GameObject slime;
    public void OnLevelWasLoaded(int level)
    {
        if (level == 0)
        {
            Instantiate(slime, new Vector2(2.8f, 2.7f), slime.transform.rotation);
        }

    }
}
