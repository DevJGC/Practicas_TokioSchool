using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funciones16 : MonoBehaviour
{
    // Ejercicio 16 - Calcular el mínimo común múltiplo
    [SerializeField] int num1;
    [SerializeField] int num2;
    int minComunMultiplo;
    int MCD; // Máximo Común Divisor

    void Start()
    {
        // Llama a la función enviando los valores
        CalculaMinimoComunMultiplo(num1, num2);
    }

    // Función para calcular el mínimo común múltiplo
    int CalculaMinimoComunMultiplo(int a, int b)
    {
        // Si el primer valor es mayor que el segundo, invierte el orden (cambia a por b)
        if (a > b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        // Bucle que mira los valores y saca el resto, y cuando ambos son 0 asigna el valor a la variable de retorno
        for (int i = 1; i < (a + 1); i++)
        {
            if (a % i == 0 && b % i == 0)
                MCD = i;
        }

        minComunMultiplo = (a * b) / MCD;

        // Muestra en consola los valores y el resultado
        Debug.Log("El mínimo común múltiplo de " + a + " y " + b + " es: " + minComunMultiplo);
        return minComunMultiplo;
    }
}