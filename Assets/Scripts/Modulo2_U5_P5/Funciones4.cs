using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funciones4 : MonoBehaviour
{

    public float[] arrayDecimales = { 1.5f, 2.4f, 4.2f };

    void Start()
    {

        testSumArray(arrayDecimales[0], arrayDecimales[1], arrayDecimales[2]);
    }

 
    void Update()
    {
        
    }

    public float testSumArray(float a, float b, float c)
    {
        float total;

        total = (a + b + c) / arrayDecimales.Length;
        Debug.Log("Resultado array media aritmética " + total);
       

        return total;
    }

}
