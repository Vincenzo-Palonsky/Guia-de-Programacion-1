//Realizá un programa que resuelva el siguiente problema:  
//Tres personas aportan diferente capital a una sociedad. Se desea saber qué porcentaje del total aportó cada una
//(indicando nombre y porcentaje) y cuál es el monto del total aportado por las tres.
//Ingresar por Inspector el ingreso del capital aportado por cada una de las personas y luego mostrar lo pedido 
//en el siguiente formato:  
//Nombre: capital aportado: $ … , Porcentaje del capital: %.... , Monto total aportado: $ …. 
//3.100/6

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_9 : MonoBehaviour
{
    public int Persona1;
    public int Persona2;
    public int Persona3;

    // Start is called before the first frame update
    void Start()
    {
        int Total = Persona1 + Persona2 + Persona3;

        int Porcentaje1 = (Persona1 * 100) / Total;
        int Porcentaje2 = (Persona2 * 100) / Total;
        int Porcentaje3 = (Persona3 * 100) / Total;

        Debug.Log("Persona1: capital aportado: $" + Persona1 + ", Porcentaje del capital: %" + Porcentaje1 + ", Monto total aportado: $" + Total);
        Debug.Log("Persona2: capital aportado: $" + Persona2 + ", Porcentaje del capital: %" + Porcentaje2 + ", Monto total aportado: $" + Total);
        Debug.Log("Persona3: capital aportado: $" + Persona3 + ", Porcentaje del capital: %" + Porcentaje3 + ", Monto total aportado: $" + Total);

    }
}
