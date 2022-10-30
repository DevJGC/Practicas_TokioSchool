using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBoletin11 : MonoBehaviour
{
    // Ejercicio 11 - Mueve objeto de 4 a -4 y de -4 a 4
    // Establece velocidad
    float velocity = 0.1f;

    // Control de dirección
    [SerializeField] bool direccion;

    void Start()
    {
        
    }
    void Update()
    {
        // Si direccion es false, se mueve de -4 a 4
        if (direccion == false)
        {
            transform.position = transform.position + new Vector3(velocity, 0, 0);        
        }

        // Si direccion es true, se mueve de 4 a -4
        if (direccion == true)
        {
            transform.position = transform.position + new Vector3(-velocity, 0, 0);       
        }
        
        // Si llega a 4 o -4, cambia dirección
        if (transform.position.x >4){direccion=true;}
        if (transform.position.x <-4){direccion=false;}

    }
}
