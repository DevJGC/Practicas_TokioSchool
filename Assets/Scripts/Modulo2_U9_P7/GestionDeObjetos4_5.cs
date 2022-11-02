using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionDeObjetos4_5 : MonoBehaviour
{
    // Ejercicio 4 y 5 - Instancia objetos y los destruye pasado un tiempo

    // Referencia del Prefab
    [SerializeField] GameObject objetoCubo;

    // Referencia del objeto contenedor
    [SerializeField] GameObject referenciaCubo;
    void Start()
    {
        // Crea 40 objetos en posiciones aleatorias y los destruye tras 2 segundos
        for(int n = 0; n < 40; n++)
        {
           referenciaCubo = Instantiate(objetoCubo, new Vector3(Random.Range(1,4), Random.Range(1,4), Random.Range(1,4)) , Quaternion.identity);

           Destroy(referenciaCubo,2f);
        } 
    }

    void Update()
    {
    
    }
}
