using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBoletin17 : MonoBehaviour
{
    // Ejercicio 17 - Time.time y Time.deltatime
    // Time.time es un contador de segundos.
    // Time.deltatime es el tiempo que ha pasado desde el último frame.
    // En este ejercicio se muestra por consola el valor de Time.time y Time.deltatime


    public float timeTime;
    public float timeDeltaTime;

    void Start()
    {
        
    }

    
    void Update()
    {
        timeTime = Time.time;
        timeDeltaTime = Time.deltaTime;

        Debug.Log(timeTime);
        Debug.Log(timeDeltaTime);

    }
}
