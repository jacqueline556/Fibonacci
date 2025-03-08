using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sucesion : MonoBehaviour
{
    void Start()
    {
        
        Fibonaccii(15);//llamo a mi metodo y digo cuantos numeros quiero que salgan
    }
    // Update is called once per frame
    void Fibonaccii(int n)//aqui se haran la cantidad de números que pida en este caso 15
    {
        int num1 = 0;//le asigno el 0 porque es el primer numero
        int num2 = 1;//y uno por ser el siguiente
        int prox;//este no llevara para poder asignarle 

        for (int j = 0; j < n; j++)//declaro mi variable como 0, j tiene que ser menor 15 el ciclo sigue, despues de cada ejecucion se le aumentara un 1 a mi variable j hasta que deje de ser menor que 15 (n)
        
        {
            if (j < 1)//si j es menor que 1, que prox sea 1, asi 1 se repetira
            {
                prox = 1;
            }

            else
            {
                prox = num1 + num2;//usando la formula, lo planteo como el proximo(prox) número es igual a la suma del primero (num1) y el segundo(num2)
                num1 = num2;//para mover/avanzar en la sucesión, num1 toma el valor de num2
                num2 = prox;//ahora num2 tomara el lugar del proximo y se repite el proceso

            }
            print(num1);
        }
    }
}