//En un casino de juegos se desea mostrar los mensajes respectivos por el puntaje obtenido en el lanzamiento de
//tres dados de un cliente, de acuerdo a los siguientes  resultados:  
//• Si los tres dados son seis, mostrar el mensaje “Excelente” 
//• Si dos dados son seis, mostrar el mensaje “Muy bien”  
//• Si un dado es seis, mostrar el mensaje “Regular”  
//• Si ningún dado se obtiene seis, mostrar el mensaje “Insuficiente” 


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_12 : MonoBehaviour
{
    public int Dado1;
    public int Dado3;
    public int Dado2;

    // Start is called before the first frame update
    void Start()
    {
        if (Dado1 == 6 && Dado2 == 6 && Dado3 == 6)
        {
            Debug.Log("Excelente");
        }

        else if (Dado1 == 6 && Dado2 == 6 || Dado1 == 6 && Dado3 == 6 || Dado2 == 6 && Dado3 == 6)
        {
            Debug.Log("Muy bien");
        }

        else if (Dado1 == 6 || Dado2 == 6 || Dado3 == 6)
        {
            Debug.Log("Regular");
        }

        else
        {
            Debug.Log("Insuficiente");
        }
    }
}
