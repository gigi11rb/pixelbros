using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire2 : MonoBehaviour
{
    public float firespeed;

    private Rigidbody2D rb;
    public GameObject fireeffect;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(firespeed * transform.localScale.x, 0);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "player")
        {
            FindObjectOfType<gamem>().HurtP5();
        }
        if (other.tag == "player2")
        {
            FindObjectOfType<gamem>().HurtP6();
        }
        if (other.tag == "trap")
        {
            FindObjectOfType<enemy_life>().enemys();
            
        }
        if (other.tag == "trap2")
        {
            FindObjectOfType<enemy_life>().enemys();
        }
        if (other.tag == "trap4")
        {
            FindObjectOfType<enemy_life1>().enemys1();
        }
        Instantiate(fireeffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
