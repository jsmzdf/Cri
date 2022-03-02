using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crecimiento : MonoBehaviour
{
    Animator anima;
    protected float dias = 0;
    protected int cantDias = 0;
    public int estado{ get;set; }
   
    void Start()
    {
        anima = GetComponent<Animator>();
        estado = 1;
    }

    // Update is called once per frame
    void Update()
    {


        dias += 10 * Time.deltaTime;
        if (dias >= 100)
        {
            Debug.Log(cantDias.ToString());
            cantDias += 1;
            dias = 0;
            if (cantDias==2) {
                anima.SetInteger("Estado", estado);
            }
            if (cantDias == 4)
            {
                estado = 2;
                anima.SetInteger("Estado", estado);
                
            }


        }
        if (cantDias>=20) {
            Destroy(gameObject);

        }
        
    }
}
