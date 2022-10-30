using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBoletin12 : MonoBehaviour
{

    // Ejercicio 12 - Mueve objeto en un área cuadrada
    // Establece velocidad
    float velocity = 0.1f;

    // Control de dirección
    [SerializeField] int direccion=0;

    void Start()
    {
        
    }
    void Update()
    {
        // Asigna la dirección de movimiento según la variable direccion
        if (direccion == 0)
        {
            transform.position = transform.position + new Vector3(velocity, 0, 0);        
        }
        if (direccion == 1)
        {
            transform.position = transform.position + new Vector3(0, -velocity, 0);       
        }
        if (direccion == 2)
        {
            transform.position = transform.position + new Vector3(-velocity, 0, 0);
        }
        if (direccion == 3)
        {
            transform.position = transform.position + new Vector3(0, velocity, 0);
        }      
    
        // Cuando llega a cada punto, cambia de dirección
        if (direccion == 0 && transform.position.x > 4) { direccion=1; }
        if (direccion == 1 && transform.position.y < -4) { direccion=2; }
        if (direccion == 2 && transform.position.x < 0) { direccion=3; }
        if (direccion == 3 && transform.position.y > 0) { direccion=0; }

    }
}
