using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Datosini : MonoBehaviour
{
    public string nombreP = "";
    public string nombreW = "";
    public string perso="";
     void Start()
    {
        
    }
    void Awake() {
        DontDestroyOnLoad(gameObject);
    }

   
    void Update()
    {
        
    }
}
