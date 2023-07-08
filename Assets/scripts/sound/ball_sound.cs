using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_sound : MonoBehaviour
{
    [SerializeField] private AudioSource ballbounc;
    public LayerMask ground;

    void OnTriggerEnter2D(Collider2D ground)
    {
        ballbounc.Play();
    }
}
