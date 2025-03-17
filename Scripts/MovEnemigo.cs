using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovEnemigo : MonoBehaviour
{


    GameObject jugador;
    Vector3 direccion = new Vector3(0, 0, 0);
    public float speed = 10.0f;



    void Start()
    {
        jugador = GameObject.FindWithTag("Jugador");
    }

  
    void Update()
    {
        direccion = jugador.transform.position - transform.position;
        direccion.Normalize();

        transform.Translate(direccion * speed * Time.deltaTime);
    }
}
