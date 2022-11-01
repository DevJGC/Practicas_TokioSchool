using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBoletin13_14 : MonoBehaviour
{

    // Ejercicio 13 y 14 - Mueve objeto en un área con forma de rombo y aumenta velocidad
    // Establece velocidad
    [SerializeField] float velocity = 0.1f;

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
            transform.position = transform.position + new Vector3(velocity, velocity, 0);        
        }
        if (direccion == 1)
        {
            transform.position = transform.position + new Vector3(velocity, -velocity, 0);       
        }
        if (direccion == 2)
        {
            transform.position = transform.position + new Vector3(-velocity, -velocity, 0);
        }
        if (direccion == 3)
        {
            transform.position = transform.position + new Vector3(-velocity, velocity, 0);
        }      
    
        // Cuando llega a cada punto, cambia de dirección y aumenta velocidad
        if (direccion == 0 && transform.position.x > 4) { direccion=1; velocity +=0.1f; }
        if (direccion == 1 && transform.position.y < -4) { direccion=2; velocity +=0.1f; }
        if (direccion == 2 && transform.position.x < 0) { direccion=3; velocity +=0.1f; }
        if (direccion == 3 && transform.position.y > 0) { direccion=0; velocity +=0.1f; }

        // Cuando la velocidad llega a 3f se vuelve a 0
        if (velocity >= 3f)
        {
            velocity = 0f;
        }

    }
}
