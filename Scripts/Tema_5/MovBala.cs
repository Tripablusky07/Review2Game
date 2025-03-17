using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovBala : MonoBehaviour
{
    private int speed = 100; // Variable para ajustar la velocidad
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    void Start()
    {
        Destroy(gameObject, 5);
    }
}
