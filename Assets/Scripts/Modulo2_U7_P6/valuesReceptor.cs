using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class valuesReceptor : MonoBehaviour
{
    // Ejercicio 5 y 6 - En este Script se capturan las variables X, Y y Z de un Script externo
    // public valuesContainer valuesContainer;
    // Ejercicio 6 - Cargo desde el editor el objeto externo
    public GameObject externo;

    void Start()
    {
        // Posiciono el objeto local con las coordenadas leidas del Script externo // Ejercicio 5
        // transform.position = new Vector3(valuesContainer.x,valuesContainer.y,valuesContainer.z); // Ejercicio 5
        // Ejercicio 6 - Lee las coordenadas del Script externo
        transform.position = new Vector3(externo.GetComponent<valuesContainer>().x, externo.GetComponent<valuesContainer>().y, externo.GetComponent<valuesContainer>().z);
    }
}

