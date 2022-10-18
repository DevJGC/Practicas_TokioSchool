using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funciones8 : MonoBehaviour
{
    // Ejercicio 8 - Variables
    public float precioBruto = 200;
    public float descuento = 10;
    float precioFinal;
    public float precioFinalPorcentaje;
    bool superiorA100;

    void Start()
    {
        // Llama a la función pasando el precio bruto y el descuento a aplicar - Responde el precio final
        CalcularDescuento(precioBruto, descuento);

        // Si el descuento es 100 o más, no muestra este mensaje, solo si es una cifra menor 
        if (superiorA100 == false)
        {
            // Muestra el texto con todos los valores de entrada y salida
            Debug.Log("Importe bruto: " + precioBruto + " con el descuento: " + descuento + "% y el precio final es de " + precioFinalPorcentaje);

        }
    }

    // Función calcular descuento - Valor de entrada precio bruto y descuento - Valor de salida el precio final
    public float CalcularDescuento(float precio, float descuento)
    {
        // Calcula el precio final
        precioFinal = (descuento / 100)* precio;
        precioFinalPorcentaje = precio - precioFinal;

        // Si el descuento es 100 o más, no se aplica el descuento
        if (descuento > 99)
        {
            Debug.Log("No puede aplicarse 100% o más");
            superiorA100 = true;
        }

        // Devuelve el precio final
        return precioFinalPorcentaje;
    }

}
