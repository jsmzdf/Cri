using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ususrio : MonoBehaviour
{
    
    public GameObject establo;
    public GameObject arthax;
    public GameObject caballo;
    
    public List<Establo> establos= new List<Establo>();
    public List<Caballito> caballos =  new List<Caballito>() ;
    public List<Arthax> arthaxs = new List<Arthax>();
    private GameObject objetoBuscado;
    public string nombre;
    public string nombreword;
    public string personheroe;
    public int gold;
    public int canmaxp;
    public int canusadap;
    public int canmaxe;
    public int canusadae;
    public int recurso;
    void Start()
    {
        if (GameObject.Find("GameControler") == true)
        {
            instanciarHero(GameObject.Find("GameControler").GetComponent<Datosini>().perso);
            
             gold=40;
               canmaxp=10;
             canusadap=1;
            canmaxe = 5;
            canusadae = 0;
            recurso =5;
}
        else {
            Debug.Log("guardada");
            gold = 40;
            canmaxp = 10;
            canusadap = 0;
            canmaxe = 5;
            canusadae = 0;
            recurso = 5;
        }
        
    }
   

    public void instanciarHero(string perso)
    {

        if (perso.Equals("Arthax"))
        {
            Arthax nuevo = gameObject.GetComponent<datos>().instaArthax(arthax);

            arthax.GetComponent<indiceInfo>().indice = arthaxs.Count;
            nuevo.objeto.GetComponent<indiceInfo>().indice = arthaxs.Count;
            arthaxs.Add(nuevo);
        }
        if (perso.Equals("Borg"))
        {


        }

    }

    public void  agregarEstabl() {
        if (canmaxe>canusadae){
            if (GameObject.Find("Barracks(Clone)") ==null)
            {

                Establo nuevo = gameObject.GetComponent<datos>().instaEstablo(establo, establos.Count);
                establo.GetComponent<indiceInfo>().indice = establos.Count;
                nuevo.objeto.GetComponent<indiceInfo>().indice = establos.Count;
                establos.Add(nuevo);
                canusadae += 1;
            }
        }
    
    }
    

  public  void agregarCaballo()
    {
       
        objetoBuscado = GameObject.Find("Barracks(Clone)");
        if (objetoBuscado != null && canmaxp>canusadap)
        {
            Caballito nuevo = gameObject.GetComponent<datos>().instanCaba(objetoBuscado,caballo, caballos.Count);
            caballo.GetComponent<indiceInfo>().indice = caballos.Count;
            nuevo.objeto.GetComponent<indiceInfo>().indice = caballos.Count;
            nuevo.setApodo("caballito");
            caballos.Add(nuevo);
            canusadap += 1;
            
        }
        
       
    }

    
    void Update()
    {
        
    }
}
