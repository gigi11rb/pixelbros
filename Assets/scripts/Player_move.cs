using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_move : MonoBehaviour
{
    public float movespeed;
    public float jumpforce;

    public KeyCode left;
    public KeyCode right;
    public KeyCode jump;
    public KeyCode throwfire;
    public KeyCode dash;

    private bool canDash = true;
    private bool isDashing;
    public float dashingPower;
    private float dashingTime = 0.2f;
    public float dashingCooldown = 2f;

    private Rigidbody2D rb;
 
    public Transform groundCheckPoint;
    public float groundCheckRadius;
    public LayerMask whatisground;

    public bool isGrounded;

    private Animator anim;

    public GameObject fire;
    public Transform fire_point;
    [SerializeField] private TrailRenderer tr;

    [SerializeField] private AudioSource shotSound;
    [SerializeField] private AudioSource jumpSound;

    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();

        anim=GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isDashing)
        {
            return;
        }
        if (Input.GetKey(dash) && canDash)
        {
            StartCoroutine(Dash());
        }
        isGrounded = Physics2D.OverlapCircle(groundCheckPoint.position , groundCheckRadius,whatisground ); 


        if (isDashing)
        {
            return;
        }
        if(Input.GetKey(left))
        {
            rb.velocity = new Vector2(-movespeed, rb.velocity.y);
            tr.emitting = true;
        
        } else if(Input.GetKey(right))
        {
            rb.velocity = new Vector2(movespeed, rb.velocity.y);
            tr.emitting = true;

        }else {

            rb.velocity = new Vector2(0 , rb.velocity.y);
        }

        if (Input.GetKeyDown(jump) && isGrounded)
        {
            rb.velocity = new Vector2( rb.velocity.x, jumpforce );
            tr.emitting = true;
            jumpSound.Play();
        }
        if(Input.GetKeyDown(throwfire))
        {
            GameObject fireclone = (GameObject)Instantiate(fire, fire_point.position, fire_point.rotation);
            fireclone.transform.localScale = transform.localScale;
            anim.SetTrigger("Throw");
            tr.emitting = true;
            shotSound.Play();
        }

        if(rb.velocity.x < 0)
        {
            transform.localScale= new Vector3(-1,1,1);
        } else if(rb.velocity.x > 0)
        {
            transform.localScale= new Vector3(1,1,1);

        }

        anim.SetFloat("Speed",Mathf.Abs(rb.velocity.x)); 
        anim.SetBool("Grounded", isGrounded);
        
    }
    private IEnumerator Dash()
    {
        canDash = false;
        isDashing = true;
        float originalGravity = rb.gravityScale;
        rb.gravityScale = 0f;
        rb.velocity = new Vector2(transform.localScale.x * dashingPower, 0f);
        tr.emitting = true;
        yield return new WaitForSeconds(dashingTime);
        tr.emitting = false;
        rb.gravityScale = originalGravity;
        isDashing = false;
        yield return new WaitForSeconds(dashingCooldown);
        canDash = true;
    }
}
