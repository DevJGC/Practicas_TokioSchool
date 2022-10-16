using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bucles12 : MonoBehaviour
{
    // Ejercicio 12 - Muestra los números primos de 0 al 10
    int cantidadTotal=10;
    
    int i;
    
    
    void Start()
    {

        while (i < cantidadTotal) 
        
        {

            if ((i == 2) || (i == 3) || (i == 5) || (i == 7))

            {

                Debug.Log("El número " + i + " es primo");

            }

            else 
            
            {
                Debug.Log("El número " + i + " no es primo");

            }


            i++;

        }




    }

    void Update()
    {
        
    }
}
