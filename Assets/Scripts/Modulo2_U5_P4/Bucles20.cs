using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bucles20 : MonoBehaviour
{

    public int[] notas; // 25 notas introducidas desde el editor
    public int[] passed; // Array para almacenar los aprobados
    public int[] failed; // Array para almacenar los suspendos
    int n; // Contador de bucle

    void Start()
    {
        
        foreach (int puntuacion in notas)  // puntacion toma el valor de cada posición del Array y notas es el índice del Array
        {
            
            Debug.Log("Puntuación " + puntuacion); // Muestra por consola la nota de esa casilla del Array


            if (puntuacion < 5) // Si la nota es menor que 5 (4 o menos) es un suspenso. Asigna la nota al Array passed, lo muestra y resetea la nota del Array original
            {
                failed[n] = puntuacion;
                Debug.Log("Suspenso en posicion " + n + " con la nota " + puntuacion);
                notas[n] = 0;
            }

            if (puntuacion > 4) // Si la nota es mayor que 4 (5 o más) es un aprobado. Asigna la nota al Array failed, lo muestra y resetea la nota del Array original
            {
                passed[n] = puntuacion;
                Debug.Log("Aprobado en posicion " + n + " con la nota " + puntuacion);
                notas[n] = 0;
            }

            n++; // Suma uno al contador
        }

    }

}
