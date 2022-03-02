using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
public class PanelItems : MonoBehaviour
{
    public UnityEngine.UI.Button activate;
    private bool activo;
    void Start()
    {
        this.gameObject.SetActive(false);
        activo = false;
    }
    public void activarmoc()
    {
        if (activo == false)
        {
            this.gameObject.SetActive(true);
            activo = true;
        }
        else
        {
            this.gameObject.SetActive(false);
            activo = false;
        }

    }
    
    void Update()
    {
        
    }
}
