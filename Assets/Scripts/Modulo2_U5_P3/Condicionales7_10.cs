using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condicionales7_10 : MonoBehaviour
{

    [SerializeField] string ciudad;
    [SerializeField] float precio;



   
    void Start()
    {
        // Ejercicio 7
        // if ((ciudad == "Madrid" || ciudad == "Barcelona" || ciudad == "Sevilla" || ciudad == "Bilbao") && precio <= 200000f)

        // Ejercicio 8
        //if ((ciudad == "Madrid" || ciudad == "Barcelona" || ciudad == "Sevilla" || ciudad == "Bilbao") && precio > 150000f)

        // Ejercicio 9 y 10
        if ((ciudad == "Madrid" || ciudad == "Barcelona" || ciudad == "Sevilla" || ciudad == "Bilbao") && (precio > 149999f && precio < 200001f))
        {
            //Debug.Log("Valido para la compra"); // Ejercicio 7
            Debug.Log("Válida para la compra"); // Ejercicio 9 y 10
        }

        // Ejercicio 9
        if ((ciudad == "Madrid" || ciudad == "Barcelona" || ciudad == "Sevilla" || ciudad == "Bilbao") && (precio > 99999f && precio < 149999f))
        {
          
            Debug.Log("Vivienda para estudiar viabilidad de compra"); // Ejercicio 9 y 10
        }

        if ((ciudad == "Madrid" || ciudad == "Barcelona" || ciudad == "Sevilla" || ciudad == "Bilbao") && (precio > 200000f && precio < 250001f))
        {
            
            Debug.Log("Vivienda para estudiar viabilidad de compra"); // Ejercicio 9 y 10

        }

        if (precio < 150000f || precio > 250000f)
        {
            Debug.Log("Vivienda no válida para compra"); // Ejercicio 9 y 10
        }

        //Debug.Log("Vivienda no coincide con requisitos"); // Ejercicio 8

    }

    void Update()
    {
        
    }
}
