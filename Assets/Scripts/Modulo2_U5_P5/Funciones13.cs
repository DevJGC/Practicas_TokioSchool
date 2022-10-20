using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funciones13 : MonoBehaviour
{
    // Ejercicio 13 - Calcula el tiempo que se tarda de A a B
    float resultadoTiempo;
    [SerializeField] float distance;
    [SerializeField] float velocity;
    [SerializeField] float hours;
    [SerializeField] int stops;

    void Start()
    {
        // Llama a la función enviando la distancia, velocidad, número de paradas de X tiempo y lo muestra por consola
        CalcularTiempo(distance, velocity, hours, stops);
        Debug.Log("La distincia " + distance + "km a la velocidad " + velocity + "km/h parando " + stops + " veces durante " + hours + "/h, se ha tardado: " + resultadoTiempo + "h.");
    }

    // Función que divide la distancia entre la velocidad y se suma el número de paradas por el tiempo de cada una y devuelve el tiempo total
    float CalcularTiempo(float d,float v, float h, int s)
    {
        float tiempo = d / v;
        tiempo = tiempo + (h * s);
        resultadoTiempo = tiempo;

        return resultadoTiempo;
    }
}
