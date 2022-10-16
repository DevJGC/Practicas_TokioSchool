using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bucles1_6 : MonoBehaviour
{

    // public int counter; // Ejercicios 1 y 2

    // public int counter = 10000; // Ejercicio 3

    public int counter = 0;  // Ejercicio 5
    public int ciclos;  // Ejercicio 6

    void Start()
    {
        // while (counter < 100) // Ejercicio 1

        // while (counter < 10000) // Ejercicio 2 Se ejecuta todo en un único frame, casi bloquea el sistema

        // while (counter > 0)  // Ejercicio 3 se para en 0

        while (counter < 5000) // Ejercicio 5 y 6
        {

            ciclos ++; // Ejercicio 6 - Cuenta los ciclos

            // counter++; // Ejercicio 1 y 2 Suma de uno en uno
            // counter--; // Ejercicio 3 Resta de uno en uno
            // Ejercicio 4 SIN SUMA NI RESTA - Si no se cumple el While, el sistema se bloquea (NO EJECUTAR!!)

            counter += 3; // Ejercicio 5 y 6 - De tres en tres


        }


    }

    
    void Update()
    {
        
    }
}
