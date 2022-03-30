//Construir un programa que simule el funcionamiento de una calculadora que puede realizar las cuatro
//operaciones aritméticas básicas (suma, resta, producto y división) con  valores numéricos enteros.  
//Se debe especificar la operación que se desea realizar ingresando una letra por Inspector
//(s para la suma, r para la resta, p para el producto y d para la división) y luego, 
//deberán ingresarse dos números enteros para así realizar la operación. Informar el resultado por pantalla.
//Nota: Se recomienda el empleo de una sentencia switch.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_14 : MonoBehaviour
{
    public string Operacion;
    public int Numero1;
    public int Numero2;

    // Start is called before the first frame update
    void Start()
    {
        switch (Operacion)
        {
            case "s":
                Debug.Log("El resultado de la suma es: " + (Numero1 + Numero2));
                break;

            case "r":
                Debug.Log("El resultado de la resta es: " + (Numero1 - Numero2));
                break;

            case "p":
                Debug.Log("El resultado del producto es: " + (Numero1 * Numero2));
                break;

            case "d":
                Debug.Log("El resultado de la división es: " + (Numero1 / Numero2));
                break;
        }
        
    }
}
