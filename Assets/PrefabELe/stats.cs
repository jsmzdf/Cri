using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System.Threading.Tasks;
public class stats : MonoBehaviour
{

    int vida = 100;
    int comida = 100;
    int activdad = 100;
    int diversion = 100;
    int aseo = 100;
    int  tiempo = 0;
    void Start()
    {
        
    }

    
    void Update()
    {
        /*tiempo = tiempo + (int)Mathf.Round(0.5f * Time.deltaTime);
      
        if (tiempo%200 >= 0) {
            comida = comida - 1;
           
            Debug.Log("c"+comida);
        }
        if (tiempo % 100 >= 0)
        {
            activdad = activdad - 1;
           
            Debug.Log("a" + activdad);
        }

        if (tiempo % 300 >= 0)
        {
            diversion = diversion - 1;
           
            Debug.Log("d" + diversion);
        }

        if (tiempo %400 >= 0)
        {
            aseo = aseo - 1;
            tiempo = 0;
            Debug.Log("as" + aseo);
        }*/



    }
}
