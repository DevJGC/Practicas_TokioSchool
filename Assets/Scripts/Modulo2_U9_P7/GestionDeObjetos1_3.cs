using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Ejercicio 3 - No es posible instanciar al propio Script
public class GestionDeObjetos1_3 : MonoBehaviour
{
    // Ejercicio 1 - Se asignan desde el editor los 2 Prefabs
    [SerializeField] GameObject cubo;
    [SerializeField] GameObject esfera;
    

    void Start()
    {
        // Ejercicio 1 y 2 - Se crean las dos instancias en las coordenadas indicadas en el ejercicio
        Instantiate(cubo, new Vector3(-2, 0, 0), Quaternion.identity);
        Instantiate(esfera, new Vector3(2, 0, 0), Quaternion.identity);   

    }
 
    void Update()
    {
        // Ejercicio 2 - Al pulsar A llama a la función de EliminarObjetos
        if (Input.GetKeyDown(KeyCode.A))
        {
            EliminarObjetos();
        }
    }

    // Ejercicio 2 - Función que busca por nombre y borra los objetos
    void EliminarObjetos()
    {
        Destroy(GameObject.Find("Cube(Clone)"));
        Destroy(GameObject.Find("Sphere(Clone)"));
    }

}
