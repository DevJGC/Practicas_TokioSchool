using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chronometer : MonoBehaviour
{
    // Ejercicio 18 - Cronómetro

    // Botón de Pausa del cronómetro
    public bool pauseChrono;

    // Contador en segundos y parámetro para iniciar
    public int iniciar=0;
    public int contador;
    

    // Guarda el tiempo transcurrido
    public float recordValue;
    
    void Update()
    {
        // Si el cronómetro está en false y "Iniciar" en 1 se ejecuta
        if (pauseChrono == false && iniciar == 1)
        {
            // Suma el "Time.deltatime" en la variable "recordValue"
            recordValue += Time.deltaTime;
            // Convierte en entero el valor de tiempo y lo vuelca en el contador, creando un cronómetro. "contador" siempre será el entero más alto hasta el momento
            contador = (int)recordValue;
            
        }

    }
}
