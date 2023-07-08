using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class gamem : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;

    public int P1life;
    public int P2life;

    public GameObject P1wins;
    public GameObject P2wins;
    public GameObject Tie;
    public GameObject camera;
    

    public GameObject[] P1fiers;
    public GameObject[] P2fiers;
    public GameObject button;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (P1life <= 0)
        {
            player1.SetActive(false);
            P2wins.SetActive(true);
            button.SetActive(true);
            
        }
        if (P2life <= 0)
        {
            player2.SetActive(false);
            P1wins.SetActive(true);
            button.SetActive(true);

        }

        if (P1life <=0 && P2life <=0)
        {
            Tie.SetActive(true);
            camera.SetActive(true);
            P1wins.SetActive(false);
            P2wins.SetActive(false);
            button.SetActive(true);
        }
        
    }
    public void HurtP1()
    {
        P1life -= 1;
        for(int i = 0;i < P1fiers.Length; i++)
        {
            if(P1life > i)
            {
                P1fiers[i].SetActive(true);
            } else{
                P1fiers[i].SetActive(false);
            }
        }

    }
    public void HurtP2()
    {
        P2life -= 1;
        for(int i = 0;i < P2fiers.Length; i++)
        {
            if(P2life > i)
            {
                P2fiers[i].SetActive(true);
            } else{
                P2fiers[i].SetActive(false);
            }
        }
    }
    public void HurtP3()
    {
        P1life -= 3;
        for(int i = 0;i < P1fiers.Length; i++)
        {
            if(P1life > i)
            {
                P1fiers[i].SetActive(true);
            } else{
                P1fiers[i].SetActive(false);
            }
        }

    }
    public void HurtP4()
    {
        P2life -= 3;
        for(int i = 0;i < P2fiers.Length; i++)
        {
            if(P2life > i)
            {
                P2fiers[i].SetActive(true);
            } else{
                P2fiers[i].SetActive(false);
            }
        }
    }
    public void HurtP5()
    {
        P1life -= 2;
        for(int i = 0;i < P1fiers.Length; i++)
        {
            if(P1life > i)
            {
                P1fiers[i].SetActive(true);
            } else{
                P1fiers[i].SetActive(false);
            }
        }

    }
    public void HurtP6()
    {
        P2life -= 2;
        for(int i = 0;i < P2fiers.Length; i++)
        {
            if(P2life > i)
            {
                P2fiers[i].SetActive(true);
            } else{
                P2fiers[i].SetActive(false);
            }
        }
    }
    public void HurtP7()
    {
        P1life -= 4;
        for(int i = 0;i < P1fiers.Length; i++)
        {
            if(P1life > i)
            {
                P1fiers[i].SetActive(true);
            } else{
                P1fiers[i].SetActive(false);
            }
        }

    }
    public void HurtP8()
    {
        P2life -= 4;
        for(int i = 0;i < P2fiers.Length; i++)
        {
            if(P2life > i)
            {
                P2fiers[i].SetActive(true);
            } else{
                P2fiers[i].SetActive(false);
            }
        }
    }


}
