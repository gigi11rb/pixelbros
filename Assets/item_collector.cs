using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class item_collector : MonoBehaviour
{
    private int coins = 0;
    [SerializeField] private Text coins_txt;
    [SerializeField] private AudioSource coinSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag ("coin"))
        {
            Destroy(collision.gameObject);
            coins++;
            coins_txt.text = "coin: " + coins;
            coinSound.Play();
        }
        if (collision.gameObject.CompareTag ("coin2"))
        {
            Destroy(collision.gameObject);
            coins++;
            coins_txt.text = "coin: " + coins;
        }

    }
}   
