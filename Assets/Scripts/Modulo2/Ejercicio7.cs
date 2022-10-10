using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7 : MonoBehaviour
{

    private string myname = "Jose";
    private int age = 45;
    private float height = 1.80f;
    private bool life = true;



    void Start()
    {
        // Todo el contenido en una unica linea
        Debug.Log("Me llamo " + myname + ", tengo " + age + " años, mido " + height + " m. y vivo (" + life + ")");


        // Todo el contenido pero cada uno en lineas separadas
        Debug.Log("Me llamo " + myname);
        Debug.Log("Tengo " + age + " años");
        Debug.Log("Mido " + height + " m");
        Debug.Log("Y vivo (" + life +")");


    }

   
    void Update()
    {
        
    }
}
