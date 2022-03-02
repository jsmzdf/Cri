using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisiones : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D col)
    {

        if (gameObject.name == "BordeMar") {
           
            if (col.GetComponent<Movimiento>().x!=0) {
                col.GetComponent<Movimiento>().cambiarDire(0);
            }
            if (col.GetComponent<Movimiento>().y != 0)
            {
                col.GetComponent<Movimiento>().cambiarDire(1);
            }
           
        }
    }
}
