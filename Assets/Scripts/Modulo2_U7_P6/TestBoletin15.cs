using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBoletin15 : MonoBehaviour
{
    // Ejercicio 15 - Comprueba los fps de cada variable según su función 
    // En primer lugar "OnGUI", después "Update" y por último "FixedUpdate"

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
        valFixedUpdate++;

    }

    void OnGUI()

    {
        valOnGUI++;
    
    }


    
    void Update()
    {
        valUpdate++;

    }
}
