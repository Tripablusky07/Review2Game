using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ataque : MonoBehaviour
{

    private AudioSource shootAudio;
    public GameObject Bala;
    public Transform[] posRotBala;
    private void Attack()
    {

        if (Input.GetMouseButtonDown(0)) // Detecta clic izquierdo
        {
            for (int i = 0; i < posRotBala.Length; i++)
            {
                // Instanciar la bala en la posición y rotación correspondientes
                Instantiate(Bala, posRotBala[i].position, posRotBala[i].rotation); 
            }
            // Reproducir sonido de disparo
            if (shootAudio != null)
            {
                shootAudio.Play();
            }

        }
    }


    void Awake()
    {
        shootAudio = GetComponent<AudioSource>();
    }



    // Update is called once per frame
    void Update()
    {
        Attack();
    }
}
