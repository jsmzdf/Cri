using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class datos : MonoBehaviour
{
    
    public Arthax instaArthax(GameObject arthax)
      
    {
        Arthax ar = new Arthax(arthax);
        Instantiate(ar.objeto, new Vector3(-500,
                       -460, 0)
                        , Quaternion.identity);
        return ar ; 
    }

    
    public Establo instaEstablo(GameObject establo, int indi) {
        Establo est = new Establo(establo);
        Instantiate(est.objeto, new Vector3(-535,
                       -459, 0)
                        , Quaternion.identity);

        return est;
    }
    public Caballito instanCaba(GameObject objetoBuscado, GameObject caballoN, int indi ) {
       
            Caballito cab = new Caballito(caballoN);

            Instantiate(cab.objeto, new Vector3(objetoBuscado.transform.position.x,
               objetoBuscado.transform.position.y - 16, 0)
               , Quaternion.identity);
        
            return cab;
    }
    public coconutTree  intaCocoTree(GameObject cocnutT,Posisiones pos) {
        coconutTree coco = new coconutTree(cocnutT);
        Instantiate(coco.objeto, new Vector3(pos.posX,
                     pos.posY, 0)
                      , Quaternion.identity);
        
        return coco;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
public class Posisiones
{

    public float posX = 0;
    public float posY = 0;
    public Posisiones()
    {
    }
    public Posisiones(float x, float y)
    {
        this.posX = x;
        this.posY = y;
    }
}
public interface iniperso
{
   
    string nameEspecie();
    string getApodo();
    void setApodo(string apodo);
    float getvel();
    void setvel(float vel);
    int getvida();
    void setvida(int vida);
    float getexp();
    void setexp(float exp);
    string getTipoItem();
    void setTipoItem(string tipoitem);
    Posisiones getPos();
    void setPos(Posisiones pos);
}
public interface iniEven{
    string nameEspecie();
    Posisiones getPos();
    void setPos(Posisiones pos);
    string getTipoItem();
    void setTipoItem(string tipoitem);


    float getvel();
    void setvel(float vel);
    void setrecursodado(int vel);
    int getoroDado();
    void setoroDado(int vel);
    int getrecursodado();

}
public interface iniEdif
{
    string nameEspecie();
    string getTipoItem();
    void setTipoItem(string tipoitem);
    Posisiones getPos();
    void setPos(Posisiones pos);
    void setoroDado(int vel);
    int getrecursodado();
    void setrecursodado(int vel);
}

public abstract class variablesPeros
{

    public GameObject objeto;
    protected Posisiones pos = new Posisiones(0,0);
    protected string apodo = "";
    protected float velocicdad = 30;
    protected int vida = 0;
    protected float exp = 0;
    protected string tipoitem = "";
    public   string persona="persona";
    

}
public abstract class variablesEvento
{
    public GameObject objeto;
    protected Posisiones pos = new Posisiones(0, 0);
    protected string tipoitem = "";
    public string evento = "evento";
    public string edificio = "edificio";
    protected float velocicdad = 10;
    protected int orodado=0;
    protected int recursosDados = 0;
    protected int vida = 0;
}
public abstract class variablesObjeto
{
    public GameObject objeto;
    protected Posisiones pos = new Posisiones(0, 0);
    protected string tipoitem = "";
    public string edificio = "edificio";
    protected int orodado = 0;
    protected int recursosDados = 0;
}

public class Caballito : variablesPeros, iniperso
{

    public Caballito()
    {
         
    }
    public Caballito(GameObject caba)
    {
        this.objeto = caba;
        this.tipoitem = persona;
            
    }
    public string getApodo()
    {
        return this.apodo;
    }

    public float getexp()
    {
        return exp;
    }

    public Posisiones getPos()
    {
        return pos;
    }

    public string getTipoItem()
    {
        return this.tipoitem;
    }

    public float getvel()
    {
        return velocicdad;
    }

    public int getvida()
    {
        return vida;
    }

    public string nameEspecie()
    {
        return "Caballo";
    }

    public void setApodo(string apodo)
    {
        this.apodo = apodo;
    }

    public void setexp(float exp)
    {
        this.exp = exp;
    }

    public void setPos(Posisiones pos)
    {
        this.pos = pos;
    }

    public void setTipoItem(string tipoitem)
    {
        this.tipoitem= tipoitem ;
    }

    public void setvel(float vel)
    {
        this.velocicdad = vel;
    }

    public void setvida(int vida)
    {
        this.vida = vida;
    }
}

public class Establo : variablesObjeto, iniEdif
{
    public Establo() {
     
       
    }
    public Establo(GameObject esta)
    {
        this.objeto = esta;
        this.tipoitem = edificio;

    }
    

    public Posisiones getPos()
    {
        return this.pos;
    }

    public int getrecursodado()
    {
        return recursosDados;
    }

    public string getTipoItem()
    {
        return this.tipoitem;
    }

   

    public string nameEspecie()
    {
        return "Establo";
    }

    public void setoroDado(int vel)
    {
        this.orodado= vel;
    }

    public void setPos(Posisiones pos)
    {
        this.pos = pos;
    }

    public void setrecursodado(int vel)
    {
        this.recursosDados = vel;
    }

    public void setTipoItem(string tipoitem)
    {
        this.tipoitem = tipoitem;
    }

  

   
}

public class Arthax : variablesPeros, iniperso
{
    public Arthax()
    {
        
     
       

    }
    public Arthax(GameObject ar)
    {
        this.objeto = ar;
        this.tipoitem = persona;
       
    }
    public string getApodo()
    {
        return this.apodo;
    }

    public float getexp()
    {
        return exp;
    }

    public Posisiones getPos()
    {
        return pos;
    }

    public string getTipoItem()
    {
        return this.tipoitem;
    }

    public float getvel()
    {
        return velocicdad;
    }

    public int getvida()
    {
        return vida;
    }

    public string nameEspecie()
    {
        return "Arthax";
    }

    public void setApodo(string apodo)
    {
        this.apodo = apodo;
    }

    public void setexp(float exp)
    {
        this.exp = exp;
    }

    public void setPos(Posisiones pos)
    {
        this.pos = pos;
    }

    public void setTipoItem(string tipoitem)
    {
        this.tipoitem = tipoitem;
    }

    public void setvel(float vel)
    {
        this.velocicdad = vel;
    }

    public void setvida(int vida)
    {
        this.vida = vida;
    }

}
public class coconutTree : variablesEvento, iniEven
{
    public coconutTree()
    {

    }
    public coconutTree(GameObject ct)
    {
        this.objeto = ct;
        this.tipoitem = evento;

    }

    public int getoroDado()
    {
        return orodado;
    }

    public Posisiones getPos()
    {
        return this.pos;
    }

    public int getrecursodado()
    {
      return recursosDados;
    }

    public string getTipoItem()
    {
        return this.tipoitem;
    }

    public float getvel()
    {
        return velocicdad;
    }

    public int getvida()
    {
        return vida;
    }

    public string nameEspecie()
    {
        return "Arbolcoco";
    }

    public void setoroDado(int vel)
    {
        this.orodado = vel;
    }

    public void setPos(Posisiones pos)
    {
        this.pos = pos;
    }

    public void setrecursodado(int vel)
    {
        this.recursosDados = vel;
    }

    public void setTipoItem(string tipoitem)
    {
        this.tipoitem = tipoitem;
    }

    public void setvel(float vel)
    {
        this.velocicdad = vel;
    }

    public void setvida(int vida)
    {
        this.vida = vida;
    }
}