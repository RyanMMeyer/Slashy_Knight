using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3Levers : MonoBehaviour
{
    private GameObject Knight;
    private GameObject Lever1;
    private GameObject Lever2;
    private GameObject Lever3;
    private GameObject Lever4;
    public GameObject part1;
    public GameObject part2;
    public GameObject part3;
    public GameObject part4;
    public GameObject part5;
    public GameObject fakePortal1;
    public GameObject fakePortal2;
    public GameObject fakePortal3;
    public GameObject fakePortal4;
    public GameObject finalPortal;
    private void Start()
    {
        Knight = GameObject.Find("Knight");
        Lever1 = GameObject.Find("Lever1");
        Lever2 = GameObject.Find("Lever2");
        Lever3 = GameObject.Find("Lever3");
        Lever4 = GameObject.Find("Lever4");
        part1.SetActive(true);
        part2.SetActive(false);
        part3.SetActive(false);
        part4.SetActive(false);
        part5.SetActive(false);
        fakePortal1.SetActive(true);
        fakePortal2.SetActive(false);
        fakePortal3.SetActive(false);
        fakePortal4.SetActive(false);

    }
    private void Update()
    {
        if (Vector2.Distance(Knight.transform.position, Lever1.transform.position) < 0.3f)
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
