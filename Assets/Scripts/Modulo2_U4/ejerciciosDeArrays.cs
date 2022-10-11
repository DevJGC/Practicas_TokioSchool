using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejerciciosDeArrays : MonoBehaviour
{

   // public float[] puntuacionesMaximas;

   // public float[] puntuacionesMaximas2;
    
    public float[] arrayDecimales = {2.3f,3.1f,4,5.5f,6.9f};
    public string[] arrayCadenaCaracteres = { "Paco", "Jose", "Miguel", "Jesus", "Maria" };
    public bool[] arrayBooleanos = { true, false, false, true, true };
    public int[] arrayEnteros1;
    public int[] arrayEnteros2 = { 6, 7, 8, 9, 10 };

    private int total;

    
   
   




    void Start()
    {
        //puntuacionesMaximas2 = new float[12] { 2, 2.2f, 3, 4, 5, 6.1f, 7, 8, 9, 1, 2.8f, 23.2f };

        //Debug.Log(arrayCadenaCaracteres[0]);
        //Debug.Log(arrayCadenaCaracteres[1]);
        //Debug.Log(arrayCadenaCaracteres[2]);
        //Debug.Log(arrayCadenaCaracteres[3]);
        //Debug.Log(arrayCadenaCaracteres[4]);

        //Debug.Log(arrayCadenaCaracteres[0] 
        //    + arrayCadenaCaracteres[1]
        //    + arrayCadenaCaracteres[2]
        //    + arrayCadenaCaracteres[3]
        //    + arrayCadenaCaracteres[4]);

        //Debug.Log(arrayDecimales[0]
        //    + arrayDecimales[1]
        //    + arrayDecimales[2]
        //    + arrayDecimales[3]
        //    + arrayDecimales[4]);


        //arrayCadenaCaracteres[0] = "Claudio";
        //arrayCadenaCaracteres[1] = "Maria";



        //arrayEnteros1[0] = arrayEnteros2[0];
        //arrayEnteros1[1] = arrayEnteros2[1];
        //arrayEnteros1[2] = arrayEnteros2[2];
        //arrayEnteros1[3] = arrayEnteros2[3];
        //arrayEnteros1[4] = arrayEnteros2[4];


        //arrayEnteros1[1] = arrayEnteros2.Length;

        //Debug.Log(arrayEnteros1[1]);



        //total = (arrayEnteros1[0]
        //    + arrayEnteros1[1]
        //    + arrayEnteros1[2]
        //    + arrayEnteros1[3]
        //    + arrayEnteros1[4])
        //    / arrayEnteros1.Length;

        //Debug.Log(total);














    }

    
    void Update()
    {

        //arrayEnteros1[0] = arrayEnteros1[0] + 1;

        //arrayEnteros1[1] = arrayEnteros1[1] + 2;

        //arrayEnteros1[2] = arrayEnteros1[2] + 3;

        //arrayEnteros1[3] = arrayEnteros1[3] + 4;



        arrayEnteros1[3] = arrayEnteros1[3] + arrayEnteros1[0];

        arrayEnteros1[0] = arrayEnteros1[0] + 2;

        arrayEnteros1[1] = arrayEnteros1[1] * 2;

        arrayEnteros1[2] = arrayEnteros1[2] * 3;

     // arrayEnteros1[3] = arrayEnteros1[3] + arrayEnteros1[0];




    }
}
