using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bucles17 : MonoBehaviour
{
    // Ejercicio 17 - Creo una variable para ver en el editor
    public int showNumber;
    public bool ascDesc;

    // Cuando coincide con cada valor "case", suma 1 a la variable, cuando sobrepasa el último valor, vuelve a 0 en el "default"
    void Update()
    {

        // Cuando llega a 10 invierte a restar 
         switch (showNumber)
           {
            case 0:

                if (ascDesc == false) { showNumber++; };
                if (ascDesc == true) { showNumber--; };

                break;

            case 1:

                if (ascDesc == false) { showNumber++; };
                if (ascDesc == true) { showNumber--; };

                break;

            case 2:

                if (ascDesc == false) { showNumber++; };
                if (ascDesc == true) { showNumber--; };

                break;

            case 3:

                if (ascDesc == false) { showNumber++; };
                if (ascDesc == true) { showNumber--; };

                break;

            case 4:

                if (ascDesc == false) { showNumber++; };
                if (ascDesc == true) { showNumber--; };

                break;

            case 5:

                if (ascDesc == false) { showNumber++; };
                if (ascDesc == true) { showNumber--; };

                break;

            case 6:

                if (ascDesc == false) { showNumber++; };
                if (ascDesc == true) { showNumber--; };

                break;

            case 7:

                if (ascDesc == false) { showNumber++; };
                if (ascDesc == true) { showNumber--; };

                break;

            case 8:

                if (ascDesc == false) { showNumber++; };
                if (ascDesc == true) { showNumber--; };

                break;

            case 9:

                if (ascDesc == false) { showNumber++; };
                if (ascDesc == true) { showNumber--; };

                break;

            case 10:

                if (ascDesc == false) { showNumber++; };
                if (ascDesc == true) { showNumber--; };

                break;

            default:

                if (showNumber == -1) { showNumber = 0; ascDesc = false; }
                if (showNumber == 11) { showNumber = 10; ascDesc = true; }

                break;

         }


    }
}
