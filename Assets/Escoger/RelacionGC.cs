using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class RelacionGC : MonoBehaviour
{
    public Text nomP;
    public Text nomW;
    public Text val;
    public Button crear;
    public Button p1;
    public Button p2;
    public GameObject datos;
    void Start()
    {

    }
    public void crearH() {
        Debug.Log(nomP.text);
        if (nomP.text == "" || nomW.text == ""|| datos.GetComponent<Datosini>().perso=="")
        {
            val.text = "enter name, mane world or select PJ";

        }
        else {
            SceneManager.LoadScene("Mundo");
        }
       
    }
    public void selecP1() {
        datos.GetComponent<Datosini>().perso = "Arthax";
    }
    public void selecP2() {
        datos.GetComponent<Datosini>().perso = "Borg";
    }
    
    void Update()
    {
        
    }
}
