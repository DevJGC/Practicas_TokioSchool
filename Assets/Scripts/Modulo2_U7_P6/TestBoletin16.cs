using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBoletin16 : MonoBehaviour
{
    // Ejercicio 16 - Comprueba los fps de cada variable según su función 
    // En primer lugar "OnGUI", después "Update" y por último "FixedUpdate"
    // Cuando cualquier variable llega a 10000 desactiva el script
    // OnGUI: Llamado múltiples veces por frame en respuesta a los eventos GUI. El Layout y los eventos de Repaint son procesado primero, seguidos por un evento de Layout y de teclado/mouse para cada evento de input
    // Update: Llamado una vez por frame, independientemente del número de veces que se renderiza el frame
    // FixedUpdate: Llamado una vez por frame, independientemente del número de veces que se renderiza el frame
    
    public int valFixedUpdate=0;
    public int valOnGUI=0;
    public int valUpdate=0;


    void Start()
    {
        
    }

    void FixedUpdate()
    
    {
       myFixedUpdate();
    }

    void OnGUI()

    {
        myOnGUI();
    }


    
    void Update()
    {
        myUpdate();
    
        // Para cuando cualquier valor llega a 10000 y además muestra los valores por consola y desactiva el Script
        if ((valFixedUpdate>= 10000) || (valOnGUI>= 10000) || (valUpdate>= 10000))  
        {
            Debug.Log("FixedUpdate: " + valFixedUpdate);
            Debug.Log("OnGUI: " + valOnGUI);
            Debug.Log("Update: " + valUpdate);
            // Desactiva el Script
            enabled = false;
        }
    }


    void myUpdate()
    {
        valUpdate++;
    }

    void myFixedUpdate()
    {
        valFixedUpdate++;
    }

    void myOnGUI()
    {
        valOnGUI++;
    }



}
