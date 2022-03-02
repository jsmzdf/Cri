using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interac : MonoBehaviour
{
    public Text nombreItemselect;
    private bool activo;
    
    public Button addCAballo;
    public Button addEstablo;

    public Text oro;
    public Text recurso;
    public Text cantidaPersonas;
    public Text cantidadEstructo;

    void Start()
    {
        
      
    }

    public void instanciarEstablo() {
        
        gameObject.GetComponent<Ususrio>().agregarEstabl();
      
    }
    public void instanciarCaballo() {
        gameObject.GetComponent<Ususrio>().agregarCaballo() ;
    }

   

    void Update()
    {
        oro.text = GetComponent<Ususrio>().gold.ToString();
        recurso.text = GetComponent<Ususrio>().recurso.ToString();
        cantidaPersonas.text= GetComponent<Ususrio>().canmaxp.ToString()+"/"+
            GetComponent<Ususrio>().canusadap.ToString();
        cantidadEstructo.text= GetComponent<Ususrio>().canmaxe.ToString() + "/" +
            GetComponent<Ususrio>().canusadae.ToString();
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null)
            {
                nombreItemselect.text =hit.collider.gameObject.name.Split('(')[0];
                hit.collider.attachedRigidbody.AddForce(Vector2.up);
                try {
                    gameObject.GetComponent<Eventos>().elenemtocliqueado(extraerIndex(hit));
                }
                catch  { }
                
            }

        }

    }

    public int extraerIndex(RaycastHit2D hit) {


        char[] a = hit.collider.gameObject.name.ToCharArray();
        string numero = "";
        for(int  x=0;x<a.Length;x++) {
            if (char.IsDigit(a[x])) {
                numero += a[x];
            }
        }

        
        return 1;


    }
   
}
