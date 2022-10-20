using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Funciones12 : MonoBehaviour
{
    // Ejercicio 12 - Calcula los catetos o la hipotenusa de un triangulo rectángulo

    // Activa en el editor los valores 
    [SerializeField] float height = 0;
    [SerializeField] float width = 6;
    [SerializeField] float hypotenuse=9;
    string textoRespuesta;
    float resultado;

    
    void Start()
    {
        // Llama a la función enviando los datos y obteniendo la respuesta. Y muestra en consola el resultado
        calcHypotenuse(height, width, hypotenuse);
        Debug.Log(textoRespuesta + resultado);

    }

    // Función para calcular cualquier lado de un triangulo rectángulo
    float calcHypotenuse(float a, float b, float h)
    {
        // Si se ha dejado en 0 el valor de la hipotenusa
        if (h == 0)
        {
            float a_square = Mathf.Pow(a, 2);
            float b_square = Mathf.Pow(b, 2);
            resultado = Mathf.Sqrt(a_square + b_square);
            textoRespuesta = "La hipotenusa es ";
        }
        
        // Si se ha dejado en 0 el valor del primer cateto
        if (a == 0)
        {
            float h_square = Mathf.Pow(h, 2);
            float b_square = Mathf.Pow(b, 2);
            float a_square = h_square - b_square;         

            a_square = Mathf.Sqrt(a_square);
            resultado = a_square;
            textoRespuesta = "El primer cateto es ";
        }

        // Si se ha dejado en 0 el valor del segundo cateto
        if (b == 0)
        {
            float h_square = Mathf.Pow(h, 2);
            float a_square = Mathf.Pow(a, 2);
            float b_square = h_square - a_square;

            b_square = Mathf.Sqrt(b_square);
            resultado = b_square;
            textoRespuesta = "El segundo cateto es ";
        }

        return resultado;

    }

}
