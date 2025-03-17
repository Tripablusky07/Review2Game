using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Seguimiento_Cam : MonoBehaviour
{

    [SerializeField] private Vector3 offset = new Vector3(0, 5, -10);
    [SerializeField] private float velocidadLineal, velocidadGiro;

    [SerializeField] private Transform target;

    private void Update()
    {
        if (target == null) { //si el objetivo no es nada se detiene

            return;
        }

        //seguimiento awsd fluido de la camara
        Vector3 posicionDeseada = target.position + target.rotation * offset;
        transform.position = Vector3.Lerp(transform.position, posicionDeseada, velocidadLineal * Time.deltaTime);
        //seguimiento rotacion fluido de la camara
        Quaternion rotacionDeseada = Quaternion.LookRotation(target.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotacionDeseada, velocidadGiro * Time.deltaTime);

    }





}
