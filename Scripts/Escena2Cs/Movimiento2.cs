using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Movimiento2 : MonoBehaviour
{

    public float speed = 1.0f;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.forward * speed * Time.deltaTime * Input.GetAxis("Vertical"));
        transform.Translate(transform.right * speed * Time.deltaTime * Input.GetAxis("Horizontal"));
    }
}
