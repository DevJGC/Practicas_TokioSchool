using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bucles12 : MonoBehaviour
{
    // Ejercicio 12 - Muestra los n�meros primos de 0 al 10
    int cantidadTotal=10;
    
    int i;
    
    
    void Start()
    {

        while (i < cantidadTotal) 
        
        {

            if ((i == 2) || (i == 3) || (i == 5) || (i == 7))

            {

                Debug.Log("El n�mero " + i + " es primo");

            }

            else 
            
            {
                Debug.Log("El n�mero " + i + " no es primo");

            }


            i++;

        }




    }

    void Update()
    {
        
    }
}
