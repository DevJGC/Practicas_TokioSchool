using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funciones15 : MonoBehaviour
{
    // Ejercicio 15 - Calcular el máximo común divisor
    [SerializeField] int num1;
    [SerializeField] int num2;
    int maxComunDivisor;
  
    void Start()
    {   
        // Llama a la función enviando los valores
        CalculaMaximoComunDivisor(num1, num2);   
    }

    // Función para calcular el máximo común divisor
    int CalculaMaximoComunDivisor(int a, int b)
    {
        // Si el primer valor es mayor que el segundo, invierte el orden (cambia x por y)
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
                maxComunDivisor = i;
        }

        // Muestra en consola los valores y el resultado
        Debug.Log("El máximo común divisor de " + a + " y " + b + " es: " + maxComunDivisor);
        return maxComunDivisor;
    }
}

