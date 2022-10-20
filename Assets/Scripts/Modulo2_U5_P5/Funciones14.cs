using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funciones14 : MonoBehaviour
{
    // Ejercicio 14 - Calcula el tiempo que se tarda de A a B más los Gastos
    float resultadoTiempo;
    [SerializeField] float distance; // ejemplo 400Km
    [SerializeField] float velocity; // ejemplo 120km/h
    [SerializeField] float hours; // 1 hora por parada
    [SerializeField] int stops; // numero de paradas

    public float presupuesto; // ejemplo 100€
    public float precioGasolina; // ejemplo 1.90€/litro
    public float consumoGasolina; // ejemplo 0.10 - Es decir, 10 litros a los 100KM
    public float costePorParada; // ejemplo 5€ por parada

    void Start()
    {
        // Llama a la función enviando la distancia, velocidad, número de paradas de X tiempo y lo muestra por consola
        CalcularTiempo(distance, velocity, hours, stops, presupuesto, precioGasolina, consumoGasolina, costePorParada);
        Debug.Log("La distincia " + distance + "km a la velocidad " + velocity + "km/h parando " + stops + " veces durante " + hours + "/h, se ha tardado: " + resultadoTiempo + "h.");
     
    }

    // Función que divide la distancia entre la velocidad y se suma el número de paradas por el tiempo de cada una y devuelve el tiempo total
    float CalcularTiempo(float d, float v, float h, int s, float presupuesto, float precioGasolina, float consumoGasolina, float costePorParada)
    {
        float tiempo = d / v;
        tiempo = tiempo + (h * s);
        resultadoTiempo = tiempo;

        // Coste de cada Parada
        float costePorParadaTotal = costePorParada * s;
        costePorParada = costePorParadaTotal;

        // Consumo de gasolina x 1km x distancia
        float tempGasolinaTotal = (precioGasolina * consumoGasolina) * d;
        consumoGasolina = tempGasolinaTotal;

        Debug.Log("El viaje tiene un presupuesto total de " + presupuesto + " y el coste de la gasolina en total es de " + consumoGasolina + " y el coste de las paradas es de " + costePorParada);

        // Suma el total del coste de las paradas y la gasolina
        float restante = presupuesto - (costePorParada + consumoGasolina);
        float suma = costePorParada + consumoGasolina;

        // Si hay suficiente con el presupuesto
        if (suma <= presupuesto)        
        { 
            Debug.Log("Por lo que el coste total del viaje es de " + (costePorParada + consumoGasolina) + ", sobran " + restante + ", por lo que el viaje es posible");
        }
        else // Si no hay suficiente con el presupuesto
        {
            Debug.Log("El viaje no es posible, ya que los gastos totales son " + suma + " y el presupesto es de " + presupuesto + ", te faltan " + (presupuesto-suma));
        }

        return resultadoTiempo;
    }
}
