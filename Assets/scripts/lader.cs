using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lader : MonoBehaviour
{
    private float vertical;
    public float speed;
    private bool islader;
    private bool isclimbing;

    [SerializeField] private Rigidbody2D rb;

    // Update is called once per frame
    void Update()
    {
        vertical = Input.GetAxis("vertical");

        if (islader && Mathf.Abs(vertical) > 0f)
        {
            isclimbing = true;
        }
    }

    private void FixedUpdate()
    {
        if (isclimbing)
        {
            rb.gravityScale = 0f;
            rb.velocity = new Vector2(rb.velocity.x, vertical * speed);
        }
        else
        {
            rb.gravityScale = 3.5f;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("lader"))
        {
            islader = true;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("lader"))
        {
            islader = false;
            isclimbing = false;
        }
    }
}
