using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funciones11 : MonoBehaviour
{
    // Ejercicio 11 - Consulta el n�mero mayor dentro de un Array
    public int[] numeros; 
    public int numeroMayor = 0;


    void Start()
    {
        // Env�a a la funci�n el Array y muestra en consola el resultado devuelto
        ConsultarElMayor(numeros);
        Debug.Log(numeroMayor);

    }

    // Funci�n que recibe el Array y devuelve el n�mero mayor
    public int ConsultarElMayor(int[] numeros) 
    
    {
        // El bucle recorre todas las posiciones del Array
        for (int i=0; i <numeros.Length; i++)
        {
            // Si el valor de la casilla X del Array es mayor que el �ltimo mayor obtenido en el ciclo, sigue buscando.
            if (numeros[i] > numeroMayor)
            { 
                numeroMayor = numeros[i];
            }

        }
        // Devuelve el n�mero mayor obtenido en todo el bucle
        return numeroMayor;
    }

}
