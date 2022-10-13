using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funciones5 : MonoBehaviour
{

    int number1 = 2;
    int number2 = 5;
    bool resultado = true; // Lo pongo de inicio en True para solo tener que calcular si no es divisible, así mostrará por defecto True sin necesidad de asignar ese valor en la función.

    
    void Start()
    {
        Calculo(number1, number2); // Envía a la función dos números enteros
        Debug.Log("Resultado " + resultado);  // Muestra el resultado del Bool - Si es True es que es divisible y si es False es que no lo es.
    }

    
    void Update()
    {
        
    }

    public bool Calculo(int a, int b)
    {
        int total;

        total = b % a; // saca el resto

        if (total != 0)  // si es distintos de 0, es que no es divisible, por el contrario sigue como True.
        {
            resultado = false;

        }

        Debug.Log("Resto " + total);

        return resultado;
    }

}
