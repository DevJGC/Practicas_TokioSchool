using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funciones9 : MonoBehaviour
{
    // Ejercicio 9 - Calcula porcentaje del segundo con respecto al primero
    public float valor1;
    public float valor2;
    public float resultado;

    void Start()
    {
        // Envia los 2 valores a la funci�n y devuelve el resultado
        Calcular(valor1, valor2);
        Debug.Log(resultado);
        
    }

    // Funci�n para calcular el porcentaje de un valor con respecto de otro
    public float Calcular(float valor1, float valor2)
    {
        resultado = (valor2 / valor1)*100;

        return resultado;
    }


}
