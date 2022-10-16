using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bucles7_8 : MonoBehaviour
{

    public int[] numbers; // Ejercicio 7 Creo un Array de 25 valores desde el Editor e introduzco valores enteros.
    public int contador; // Ejercicio 7 Cuenta los pasos del bucle While
    // int resto; // Ejercicio 7 Variable contenedora del resto de la división
    int resto3; // Ejercicio 8 Variable contenedora del resto de la división entre 3
    int resto5; // Ejercicio 8 Variable contenedara del resto de la división entre 5


    void Start()
    {
        while (contador < numbers.Length) // Ejercicio 7 Suma uno más uno mientras no llegue al número total el índice del Array
        {

            //  resto = numbers[contador] % 2; // Ejercicio 7 Calcula el resto de los valores del Array
            resto3 = numbers[contador] % 3; // Ejercicio 8 Calcula el resto de los valores del Array
            resto5 = numbers[contador] % 5; // Ejercicio 8 Calcula el resto de los valores del Array

            // if (resto == 0) // Ejercicio 7 Si es divisible

            if (resto3 == 0) // Ejercicio 8 

            {
                // Debug.Log(numbers[contador]); // Ejercicio 7 Solo muestra los números que son divisibles entre 2
                Debug.Log("Divisible entre 3: " + numbers[contador]); // Ejercicio 8 Muestra los múltiplos de 3

            }


            if (resto5 == 0) // Ejercicio 8

            {
                // Debug.Log(numbers[contador]); // Ejercicio 7 Solo muestra los números que son divisibles entre 2
                Debug.Log("Divisible entre 5: " + numbers[contador]); // Ejercicio 8 Muestra los múltiplos de 5

            }


            contador++; // Ejercicio 7 y 8 Suma de uno en uno

           
        }


    }

    
  
}
