using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBoletin5_4 : MonoBehaviour
{
    // Ejercicio 4
    // Declara la Masa del objeto propio (Cube)
    [SerializeField] Rigidbody rb;

    // Declara la masa de un objeto externo (Sphere)
    public Rigidbody masaOtro;
  

    void Start()
    {
        // Carga en el objeto externo, la masa del objeto propio
        masaOtro.GetComponent<Rigidbody>().mass = rb.GetComponent<Rigidbody>().mass;

    }

    
    void Update()
    {
        
    }
}
