using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//CODIGO DEL ENEMIGO AUN NO ESTA TERMINADO!!!
public class Enemigo : MonoBehaviour
{// Aqui esta todo lo que va a ejecutar el enemigo como su rutina la cual va ser alatoria y las animaciones las cuales va a ejecutar 
    public int rutina;
    public float corometro;
    public Animator ani;
    public Quaternion angulo;
    public float grado;
    public float velocidad = 15f;

    public GameObject target;
    public bool atacando;

    void Start()
    {// Aqui le estamos diciendo las anamiaciones del jugador las cuales son esperar,correr,atacar,
        ani = GetComponent<Animator>();
        target = GameObject.Find("Player");
    }


    void Update()
    {//aqui es donde estamos indicando el comportamiento del enemigo
        Comportamiento_Enemigo();
        
    }
    //En esta ultima le estamos indicando todo el cokportamiento que va tener nuestro enemigo  y las aniamciones las cuales debe de activar cuando se cumpla las  condiciones 
    public void Comportamiento_Enemigo()
    {
        if (Vector3.Distance(transform.position, target.transform.position) > 5)
        {
            ani.SetBool("run", false);
            corometro += 1 * Time.deltaTime;
            if (corometro >=4)
            {
                rutina = Random.Range(0, 12);
                corometro = 0;
            }

            switch (rutina)
            {
                case 0:
                ani.SetBool("walk",false);
                break;

                case 1:

                grado = Random.Range(0, 360);
                angulo = Quaternion.Euler(0, grado, 0);
                rutina++;
                break;

                case 2:
               transform.rotation = Quaternion.RotateTowards(transform.rotation, angulo, 0.5f);
               transform.Translate(Vector3.forward * 1 * Time.deltaTime);
               ani.SetBool("walk", true);
               break;
            }
        }
        else
        { // En esta parte es para que nuestro enemigo puede atacar al jugador  
            if (Vector3.Distance(transform.position, target.transform.position) > 1 && !atacando)
            { // Aqui estamos diciendo el comportamiento que tiene que hacer cuando vea al jugador 
                var lookPos = target.transform.position - transform.position;
                lookPos.y = 0;
                var rotation = Quaternion.LookRotation(lookPos);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, 2);
                ani.SetBool("walk", false);

                ani.SetBool("run", true);
                transform.Translate(Vector3.forward * 2 * Time.deltaTime);

                ani.SetBool("attack", false);
            }
            else //Aqui estamos diciendo que cancele las animaciones de caminar,correr, y que active la animacion de attack
            {
                ani.SetBool("walk", false);
                ani.SetBool("run", false);

                ani.SetBool("attack", true);
                atacando = true;
            }

            
        }
    }
 // En esta  parte del codigo es para evitar que el perosnaje haga la animacion de ataque
    public void Final_Ani()
    {
        ani.SetBool("attack", false);
        atacando = false;
    }
}
