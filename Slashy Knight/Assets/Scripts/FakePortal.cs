using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakePortal : MonoBehaviour
{
    public GameObject teleportPoint;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Knight")
        {
            collision.gameObject.transform.position = teleportPoint.gameObject.transform.position;
        }
    }
}
