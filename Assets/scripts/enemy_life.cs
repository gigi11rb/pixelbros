using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class enemy_life : MonoBehaviour
{
    public GameObject player1;

    public int Enemy;

    public GameObject[] Enemy_bar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Enemy <= 0)
        {
            player1.SetActive(false);
        }
        
    }
    public void enemys()
    {
        Enemy -= 2;
        for(int i = 0;i < Enemy_bar.Length; i++)
        {
            if(Enemy > i)
            {
                Enemy_bar[i].SetActive(true);
            } else{
                Enemy_bar[i].SetActive(false);
            }
        }

    }
}
