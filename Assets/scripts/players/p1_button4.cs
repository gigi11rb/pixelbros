using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p1_button4 : MonoBehaviour
{
    public GameObject P1;
    public GameObject P2;
    public GameObject P3;
    public GameObject P4;
    public GameObject P5;
    public GameObject P6;
    public GameObject P7;
    public GameObject P8;

    public void StartGame()
    {
        P1.SetActive(false);
        P2.SetActive(false);
        P3.SetActive(false);
        P4.SetActive(false);
        P5.SetActive(true);
        P6.SetActive(false);
        P7.SetActive(false);
        P8.SetActive(false);
    }
}
