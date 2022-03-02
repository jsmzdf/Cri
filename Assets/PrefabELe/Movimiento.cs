using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{

    //Animator anima;
    Rigidbody2D cuer;
    Vector2 mov;
    float speed = 30f;
    public float y = 0f;
    public float x = 0f;
    public float aux = 0;
    private bool choca=false;
    public bool movimient = false;

    void Start() {
       // anima = GetComponent<Animator>();
        cuer = GetComponent<Rigidbody2D>();

    }
    void seMueve() {
        int lado = Random.Range(0, 2);
        if (lado == 0)
        {
            x = Random.Range(-1, 2);
            y = 0;
        }
        else if (lado == 1) {
            y = Random.Range(-1, 2);
            x = 0;
        }
        if (x == 0 && y == 0) {
            seMueve();
        }

    }
    public void cambiarDire(int lado) {
        choca = true;
       
        if (lado== 0) {
          
            x = x*-1;
            y = 0;
        }
        if (lado == 1)
        {
            
           x = 0;
            y = y * -1 ;
        }


        mov = new Vector2(x, y);
        
    }
    
    void Update()
    {
        //Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")
        // mov = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        if (mov != Vector2.zero )
        {
           /* anima.SetFloat("Movx", mov.x);
            anima.SetFloat("Movy", mov.y);
            anima.SetBool("Caminando", true);*/
            if (choca == true)
            {
                if (aux > 0){
                    aux = 0;
              }
         
                choca = false;
            }
        
            aux += 30 * Time.deltaTime;
            movimient = true;

        }
        else {
          /*  anima.SetBool("Caminando", false);*/
        }
        if (aux == 0 && movimient == false) {
            seMueve();
            mov = new Vector2(x, y);

            movimient = true;
        }
        if (aux > 100 && choca==false) {
            aux = 0;
            seMueve();
            mov = new Vector2(x, y);
            movimient = false;
        }


    }
    void FixedUpdate() {

        cuer.MovePosition((Vector2)cuer.position + mov * speed * Time.deltaTime);

    }
   
}
