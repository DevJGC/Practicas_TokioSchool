using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bucles10_11 : MonoBehaviour
{

    public int[] numeros; // Ejercicio 10 - Array 
    int i; // Ejercicio 10 - Contador del While
    int average; // Ejercicio 11 - Variable que almacenará la media aritmética

    void Start()
    {

        while (i<numeros.Length)  // Ejercicio 10 - Se ejecuta durante todo el Array
        
        {
            numeros[i] = Random.Range(0, 10); // Ejercicio 10 - Genera un número aleatório y lo asigna al valor del Array

            i++; // Ejercicio 10 - Suma 1
      
        }


        // Ejercicio 11
        foreach (int puntuacion in numeros) // Ejercicio 11 - Recoge todos los valores del Array y saca al media
        {
            average += puntuacion;
        }
        average = average / numeros.Length;
        Debug.Log(average);


    }

    
    void Update()
    {
        
    }
}
