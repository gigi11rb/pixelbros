using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    public float timeStart = 200;
    public Text textBox;
    public GameObject ball;
    public GameObject ball2;
    public GameObject ball3;
    public GameObject ball4;
    public GameObject ball5;

	// Use this for initialization
	void Start () {
        textBox.text = timeStart.ToString();
	}
	
	// Update is called once per frame
	void Update () {
        timeStart -= Time.deltaTime;
        textBox.text = Mathf.Round(timeStart).ToString();
        if (timeStart <= 54)
        {
            ball.SetActive(true);
        }
        if (timeStart <= 42)
        {
            ball2.SetActive(true);
        }
        if (timeStart <= 34)
        {
            ball3.SetActive(true);
        }
        if (timeStart <= 30)
        {
            ball4.SetActive(true);
        }
        if (timeStart <= 22)
        {
            ball5.SetActive(true);
        }
	}
}