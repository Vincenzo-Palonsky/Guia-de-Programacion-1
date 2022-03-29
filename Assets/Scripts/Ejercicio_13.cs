//Un obrero necesita calcular su salario semanal, el cual se obtiene de la siguiente  manera:  
//• Si trabaja 40 horas o menos se le paga $16 por hora(crear una constante para almacenar el 16)
//• Si trabaja más de 40 horas se le paga $16 por cada una de las primeras 40 horas y $20  por cada hora extra.
//(crear una constante para almacenar el 20)
//Ingresar por Inspector la cantidad de horas trabajadas en la semana, y mostrar por pantalla el salario correspondiente.


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_13 : MonoBehaviour
{
    public int HorasTrabajadas;

    // Start is called before the first frame update
    void Start()
    {
        int Salario = 16;
        int SalarioExtra = 20;

        if (HorasTrabajadas <= 40)
        {
            Debug.Log("El salario de la semana es $" + (Salario * HorasTrabajadas));
        }

        else if (HorasTrabajadas > 40)
        {
            Debug.Log("El salario de la semana es $" + ((Salario * 40) + (SalarioExtra * (HorasTrabajadas - 40))));
        }
    }
}
