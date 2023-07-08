using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump_pad1 : MonoBehaviour
{
    public float bounc;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("player2"))
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bounc, ForceMode2D.Impulse);
        }
    }
}
