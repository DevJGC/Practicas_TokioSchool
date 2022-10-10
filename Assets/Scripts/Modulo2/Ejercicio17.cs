using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio17 : MonoBehaviour
{

    public float datoAEvaluar;
    private float porcentaje25;
    private float porcentaje50;
    private float porcentaje75;

    
    void Start()
    {


        porcentaje25 = datoAEvaluar * 0.25f;
        Debug.Log(porcentaje25);

        porcentaje50 = datoAEvaluar * 0.50f;
        Debug.Log(porcentaje50);

        porcentaje75 = datoAEvaluar * 0.75f;
        Debug.Log(porcentaje75);



    }

 
    void Update()
    {
        
    }
}
