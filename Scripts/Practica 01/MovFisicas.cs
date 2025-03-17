 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovFisicas : MonoBehaviour
{
    public float fuerzaLineal; // aceleracion
    public float fuerzaAngular; //giro




    void Start()
    {
       
    }




    void FixedUpdate()
    {


        Rigidbody rb = GetComponent<Rigidbody>();

        //movimiento hacia adelante y atrás
        float aceleracion = Input.GetAxis("Vertical"); // W/S o flechas arriba/abajo
        Vector3 direccionMov = transform.forward * aceleracion * fuerzaLineal * Time.fixedDeltaTime;

        //aplicar fuerza
        rb.AddForce(transform.forward * aceleracion * fuerzaLineal);

        //movimiento de giro
        float giro = Input.GetAxis("Horizontal");
        Vector3 direccionGiro = transform.up * giro * fuerzaAngular * Time.fixedDeltaTime;
        
        //aplicar fuerza
        rb.AddTorque(transform.up * giro * fuerzaAngular);

    }








}
