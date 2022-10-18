using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funciones11 : MonoBehaviour
{
    // Ejercicio 11 - Consulta el número mayor dentro de un Array
    public int[] numeros; 
    public int numeroMayor = 0;


    void Start()
    {
        // Envía a la función el Array y muestra en consola el resultado devuelto
        ConsultarElMayor(numeros);
        Debug.Log(numeroMayor);

    }

    // Función que recibe el Array y devuelve el número mayor
    public int ConsultarElMayor(int[] numeros) 
    
    {
        // El bucle recorre todas las posiciones del Array
        for (int i=0; i <numeros.Length; i++)
        {
            // Si el valor de la casilla X del Array es mayor que el último mayor obtenido en el ciclo, sigue buscando.
            if (numeros[i] > numeroMayor)
            { 
                numeroMayor = numeros[i];
            }

        }
        // Devuelve el número mayor obtenido en todo el bucle
        return numeroMayor;
    }

}
