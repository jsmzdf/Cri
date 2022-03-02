using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Eventos : MonoBehaviour
{
    public Text diastx;
    protected float dias = 0;
    protected int cantDias = 1;
    private GameObject objetoBuscado;
    public GameObject coco;
    public List<coconutTree> cocos = new List<coconutTree>();
    public void instanciarCocotre()
    {
        for (int x=0;x<4;x++) {
           
            Posisiones pos = new Posisiones(-615 + 16*x, -460);
            
            coconutTree nuevo = gameObject.GetComponent<datos>().intaCocoTree(coco,pos);
            coco.name = "CoconutTrees" + x.ToString();
            nuevo.objeto.name = "CoconutTrees" + x.ToString();
            nuevo.setoroDado(Random.Range(1, 5));
            nuevo.setrecursodado(Random.Range(1, 5));
            cocos.Add(nuevo);
        }
        
        
    }
    void Start()
    {
        
    }

    public int eventoAleatorio() {
        return Random.Range(0, 2); 
    }
    public void generarPalmeras()
    {
        objetoBuscado = GameObject.Find("CoconutTrees0(Clone)");
        if (objetoBuscado == null) {
            instanciarCocotre();
        }
    }
    public void activarEvento(int evento) {
       
        switch (evento)
        {
            case 1:
                generarPalmeras();
                break;
            case 2:
               
                break;
            default:
               
                break;
        }
    }
    public void elenemtocliqueado(int indice) {

        gameObject.GetComponent<Ususrio>().gold += cocos[indice].getoroDado();
        gameObject.GetComponent<Ususrio>().recurso += cocos[indice].getrecursodado();
        


    }

    void Update()
    {
       dias += 10 * Time.deltaTime;

        if (dias >= 100 && cantDias > 0)
        {

            diastx.text = "Día" + cantDias.ToString();
            cantDias += 1;
            dias = 0;
            activarEvento(eventoAleatorio());

        }
        else {
            diastx.text = "Día" + cantDias.ToString();
        }
      
    }
}
