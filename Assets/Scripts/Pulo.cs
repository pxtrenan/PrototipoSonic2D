using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulo : MonoBehaviour
{

    public LayerMask Solo;
    public Transform ChecadorDeSolo;
    bool estanochao;
    bool estapulando;
    bool animacao;
    public float ForcaDePulo;
    public float AnguloDeContato;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         Rigidbody2D Sonic = GetComponent<Rigidbody2D>();
        estanochao = Physics2D.OverlapCircle(ChecadorDeSolo.position, AnguloDeContato, Solo);
        if(estanochao)
        {
            animacao = true;
        }
        else{
            animacao = false;
        }
        if(animacao)
        {
            GetComponent<Animator>().SetBool("pulando", false);
        }
        else{
            GetComponent<Animator>().SetBool("pulando", true);
            GetComponent<Animator>().SetBool("andando", false);
        }
               
        if (Input.GetButtonDown("Jump") && estanochao)
        {
            estapulando = true;
        }
        if(estapulando){
            Sonic.AddForce(new Vector2(0, ForcaDePulo));
            estapulando = false;
    }
    }
    
    public void Pular(){
         Rigidbody2D Sonic = GetComponent<Rigidbody2D>();
        estanochao = Physics2D.OverlapCircle(ChecadorDeSolo.position, AnguloDeContato, Solo);
        if(estanochao)
        {
            animacao = true;
        }
        else{
            animacao = false;
        }
        if(animacao)
        {
            GetComponent<Animator>().SetBool("pulando", false);
        }
        else{
            GetComponent<Animator>().SetBool("pulando", true);
            GetComponent<Animator>().SetBool("andando", false);
        }
               
        if (estanochao)
        {
            estapulando = true;
        }
        if(estapulando){
            Sonic.AddForce(new Vector2(0, ForcaDePulo));
            estapulando = false;
    }
}
    
}
