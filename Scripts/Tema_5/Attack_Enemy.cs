using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_Enemy : MonoBehaviour
{ 
    [SerializeField] private GameObject Bala_Vacio; //Variable que almacena el prefab
    [SerializeField] private Transform[] posRotBullet; // Variable que almacena posiciones de los Empty Objects
    [SerializeField] private float timeBetweenBullets;// Variable para ajustar el tiempo entre disparos
    private AudioSource shootAudio; // Variable para almacenar el componente AudioSource


    void Awake()
    {
        shootAudio = GetComponent<AudioSource>(); // Cargamos el componente
        InvokeRepeating("Attack", 1, timeBetweenBullets); // Tiempo entre disparos
    }



    public void Attack()
    {
       // Debug.Log("Disparando..."); // Verifica si se llama repetidamente
        if (shootAudio != null) // Reproducir sonido de disparo
        {
            shootAudio.Play();
        }


        for (int i = 0; i < posRotBullet.Length; i++) // Recorre todas las posiciones y rotaciones de disparo almacenadas en el array
        { // Instancia un objeto 'Bala_Vacio' en la posición y rotación de cada punto en 'posRotBullet'
            Instantiate(Bala_Vacio, posRotBullet[i].position, posRotBullet[i].rotation);
        }

    }
    void OnDrawGizmos() //Metodo para invocar gizmos y orientar el prefab
    {
        Gizmos.color = Color.green;
        for (int i = 0; i < posRotBullet.Length; i++)
        {
            Gizmos.DrawLine(posRotBullet[i].position, posRotBullet[i].position + posRotBullet[i].forward * 2);
        }
    }
}
