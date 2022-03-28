//2. Realizá un programa que, siendo num1 y num2 variables enteras con valores 4 y 5, 
//respectivamente, realice la operación correspondiente y muestre el resultado en pantalla: 
//a.Suma
//b.Producto


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int num1 = 4;
        int num2 = 5;
        
        Debug.Log("a. " + (num1 + num2));
        Debug.Log("b. " + (num1 * num2));
    }
}
