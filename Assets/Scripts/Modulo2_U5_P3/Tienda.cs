using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tienda : MonoBehaviour
{
    [SerializeField]
    // string[] productos = { "agua", "pan", "leche", "mantequilla", "vino" }; Ejercicio 15
    string[] productos = { "huevos", "pan", "leche" }; // Ejercicio 16



   
    void Start()
    {
        // Ejercicio 15 y 16
        if ((productos[0] == "leche" || productos[1] == "leche" || productos[2] == "leche") && (productos[0] == "huevos" || productos[1] == "huevos" || productos[2] == "huevos"))
        {
            Debug.Log("Tenemos leche y huevo");
        }
  
    }

   
    void Update()
    {
        
    }
}
