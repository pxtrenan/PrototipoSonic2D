using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float velocidade;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
     void Update()
    {
        Rigidbody2D Sonic = GetComponent<Rigidbody2D>();
        float hori = Input.GetAxis("Horizontal");

        Sonic.velocity = new Vector2(hori * velocidade, Sonic.velocity.y);

        if (hori<0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else if (hori>0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }

        if (hori > 0 || hori <0)
        {
            GetComponent<Animator>().SetBool("andando", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("andando", false);
        }
    }
}
