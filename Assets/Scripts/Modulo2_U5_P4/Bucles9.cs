using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bucles9 : MonoBehaviour
{
    public int[] numbers; 
    public int contador;
    public int sumaTotal=0;
    public int total;


    void Start()
    {
        while (contador < numbers.Length)  // Bucle mientras no termine de leer el Array

        {

            total = numbers[contador] * 10; // Multiplica cada casilla del Array

            Debug.Log(total); // Muestra el total de cada casilla del Array

            contador++; // Aumenta en uno el bucle

        }


        foreach (int puntuacion in numbers) // Va casilla a casilla del array

        {
            sumaTotal += puntuacion; // Y los suma todos

        }

        sumaTotal = (sumaTotal * 10); // Lo multiplica por 10
        Debug.Log(sumaTotal); // Muestra la suma de todos los valores




    }
}
