using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funciones7 : MonoBehaviour
{

    // Ejercicio 7 - Busca coincidencias de nombres en un Array
    public string[] nombres; // Array con 10 nombres de vecinos   
    public int v; // Contador de coincidencias de nombres

    void Start()
    {
        // Llama a la función y muestra el valor devuelto
        BuscaNombres("Jose");
        Debug.Log(v);
    }


    // Recorre con un bucle todas las posiciones del Array buscando un nombre, cuando lo encuentra suma 1 a v  
    public int BuscaNombres(string nombre) 
    {  
        for (int i = 0; i < nombres.Length; i++)       
        {
            if (nombres[i] == nombre)            
            {
                v++;         
            }       
        }

        return v;
    }
}
