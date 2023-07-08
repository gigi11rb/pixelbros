using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_life : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("trap"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); 

        }
        if (collision.gameObject.CompareTag("trap3"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); 

        }
        if (collision.gameObject.CompareTag("trap4"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); 

        }
    }

}
