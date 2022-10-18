using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funciones10 : MonoBehaviour
{
    // Ejercicio 10 - Calcular el d�a de la semana y el mes con el �nico dato del d�a

    // Variable para poner en el editor, poner entre el 1 y el 365
    public int day;
 
    // Variables 
    public string mes;
    public string diaSemana;
    public int dia; // Variable que se env�a a la funci�n ( podr�a hacerse tambi�n mediante Return )


    void Start()
    {
        // Llama a la funci�n y muestra por consola el d�a introducido, el mes y dia de la semana resultantes
        CalcularMes(day);
        Debug.Log("El d�a " + day + " corresponde al mes de " + mes + " y es " + diaSemana);
        
    }

    // funci�n para calcular el d�a de la semana y el mes
    public void CalcularMes (int dia)
    {
        // Mira por rangos los meses del a�o seg�n el d�a en cuesti�n
        if (dia >= 1 && dia <= 31) { mes = "Enero"; }
        if (dia >= 32 && dia <= 59) { mes = "Febrero"; }
        if (dia >= 60 && dia <= 90) { mes = "Marzo"; }
        if (dia >= 91 && dia <= 120) { mes = "Abril"; }
        if (dia >= 121 && dia <= 151) { mes = "Mayo"; }
        if (dia >= 152 && dia <= 181) { mes = "Junio"; }
        if (dia >= 182 && dia <= 212) { mes = "Julio"; }
        if (dia >= 213 && dia <= 243) { mes = "Agosto"; }
        if (dia >= 244 && dia <= 273) { mes = "Septiembre"; }
        if (dia >= 274 && dia <= 304) { mes = "Octubre"; }
        if (dia >= 305 && dia <= 334) { mes = "Noviembre"; }
        if (dia >= 335 && dia <= 365) { mes = "Diciembre"; }

        // Si est� fuera del rango, muestra error
        if (dia < 1 || dia > 365)
        {
            Debug.Log("No est� en el rango");
        }

        // Saca el resto entre 7, y el resultado lo compara en el Switch (0 - Dominio - 1 Lunes - 2 Martes, etc...)
        int resto;
        resto = dia % 7;

        switch (resto)
        {
            case 1:
                diaSemana = "Lunes";
                break;
            case 2:
                diaSemana = "Martes";
                break;
            case 3:
                diaSemana = "Miercoles";
                break;
            case 4:
                diaSemana = "Jueves";
                break;
            case 5:
                diaSemana = "Viernes";
                break;
            case 6:
                diaSemana = "Sabado";
                break;
            case 0:
                diaSemana = "Domingo";
                break;

        }       
        
    }

}
