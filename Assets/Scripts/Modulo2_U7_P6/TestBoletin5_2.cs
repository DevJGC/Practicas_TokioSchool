using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBoletin5_2 : MonoBehaviour
{
    // Ejercicio 2 - Escala un objeto externo
    // Crea una variable pública de tipo GameObject
    public GameObject objeto;
    void Start()
    {
        // Escala el objeto
        objeto.transform.localScale *= 2;

    }

    void Update()
    {
        
    }
}
