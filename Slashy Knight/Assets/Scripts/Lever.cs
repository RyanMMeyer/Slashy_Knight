using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    private GameObject Knight;
    public GameObject doorsClosed;
    public GameObject doorsOpen;
    public GameObject returningPortal;
    public GameObject nextLevelPortal;
    public GameObject fakePortal1;
    public GameObject fakePortal2;
    public GameObject fakePortal3;
    public GameObject fakePortal4;
    public GameObject fakePortal5;

    private void Start()
    {
        Knight = GameObject.Find("Knight");
        doorsOpen.SetActive(false);
        returningPortal.SetActive(false);
        nextLevelPortal.SetActive(false);
        fakePortal1.SetActive(true);
        fakePortal2.SetActive(true);
        fakePortal3.SetActive(true);
        fakePortal4.SetActive(true);
        fakePortal5.SetActive(true);
    }
    private void Update()
    {
        if (Vector2.Distance(Knight.transform.position, this.gameObject.transform.position) < 0.3f)
        {
            doorsClosed.SetActive(false);
            doorsOpen.SetActive(true);
            returningPortal.SetActive(true);
            nextLevelPortal.SetActive(true);
            fakePortal1.SetActive(false);
            fakePortal2.SetActive(false);
            fakePortal3.SetActive(false);
            fakePortal4.SetActive(false);
            fakePortal5.SetActive(false);
        }
    }
}
