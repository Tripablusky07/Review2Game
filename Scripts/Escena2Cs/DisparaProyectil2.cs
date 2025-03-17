using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparaProyectil2 : MonoBehaviour
{

    public GameObject Hamburguesa;
    private GameObject lanzador;



    void Start()
    {
        lanzador = GameObject.Find("lanzador");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))

            Instantiate(Hamburguesa, lanzador.transform.position, lanzador.transform.rotation);
    }
}
