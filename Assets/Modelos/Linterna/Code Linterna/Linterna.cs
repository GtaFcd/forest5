using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Linterna : MonoBehaviour
{
    public Light luzlinterna;
    public bool activLight; 
    public float cantBateria = 100;
    public float perdidaBteria = 0.6f;
    public bool linternaEnMano;

    [Header("Visuales")]
    public Image pila1;
    public Image pila2;
    public Image pila3;
    public Image pila4;
    public Sprite pilaVacia;
    public Sprite pilaLlena;
    public Text porcentaje;

    void Update()
    {

        cantBateria = Mathf.Clamp(cantBateria, 0, 100);// esto es la cantidaad de la bateria la cual va indicar nuestro limite 
        int valorBateria = (int) cantBateria;
        porcentaje.text = valorBateria.ToString() +"%";

        if (Input.GetKeyDown(KeyCode.F))
        {
            activLight = !activLight; //esta es la activacion de la luz en la linterna marcado el verdadero o falso 

            if (activLight == true)
            {
                luzlinterna.enabled = true;
            }

            if (activLight == false)
            {
                luzlinterna.enabled = false;
            }
      
        }

        if (activLight == true && cantBateria >0)
        {
            cantBateria -= perdidaBteria * Time.deltaTime;
        }

        if (cantBateria == 0)
        {
            luzlinterna.intensity = 0f;
            pila1.sprite = pilaVacia;
        }

        if (cantBateria > 0 && cantBateria <= 25)
        {
            luzlinterna.intensity = 1f;
            pila1.sprite = pilaLlena;
            pila2.sprite = pilaVacia;
        }

        if (cantBateria > 25 && cantBateria <= 50)
        {
            luzlinterna.intensity = 2f;
            pila2.sprite = pilaLlena;
            pila3.sprite = pilaVacia;
        }

        if (cantBateria > 50 && cantBateria <= 75)
        {
            luzlinterna.intensity = 3f;
            pila3.sprite = pilaLlena;
            pila4.sprite = pilaVacia;
        }

        if (cantBateria > 75 && cantBateria <= 100)
        {
            luzlinterna.intensity = 5f;
            pila4.sprite = pilaLlena;
        }
    }    
    
}