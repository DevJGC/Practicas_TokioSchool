using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bucles13 : MonoBehaviour
{
    // Ejercicio 13 -  Declaro variables e inicializo el Array
    public string[] edificio1 = { "Paco", "Jose", "Manolo", "Pilar", "Juan", "Federico", "Antonio", "Jesus", "Maria", "Encarna", "Julia", "Pepita" };
    int contador;
    int antonios;
        
    void Start()
    {
        // Cuenta los "Antonios" que hay en todo el Array
        while(contador < edificio1.Length)
        {          
            if (edificio1[contador] == "Antonio")           
            {
                antonios++;

            }
            contador++;
        }

        // Si no hay Antonios
        if (antonios == 0)

        {
            Debug.Log("No hay ningún Antonio en este edificio");
        }

        // Si hay un Antonio
        else if (antonios == 1) 
        
        {
            Debug.Log("He encontrado a Antonio");
        }

        // Si hay más de un Antonio
        else if (antonios > 1)

        {
            Debug.Log("He encontrado a los Antonios");
        }

    }

   
    void Update()
    {
        
    }
}
