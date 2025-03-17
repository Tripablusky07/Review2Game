using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
   [SerializeField] private int speed = 12; // Velocidad de movimiento del enemigo
    [SerializeField] private float distanceToPlayer = 6; // Distancia mínima a mantener del jugador
    GameObject Player; // Referencia al jugador




    void Awake(){

Player = GameObject.FindGameObjectWithTag("Player"); // Busca el GameObject con la etiqueta "Player"


    }






    void Update()
    {
        // Si no se encuentra el jugador, no hace nada
        if (Player == null)
            return;

        // Obtiene la distancia actual entre el enemigo y el jugador
        float distance = Vector3.Distance(transform.position, Player.transform.position);

        // Si la distancia al jugador es mayor a la distancia mínima, persigue al jugador
        if (distance > distanceToPlayer)
        {
            FollowPlayer();
        }

        // Hace que el enemigo mire hacia el jugador
        transform.LookAt(Player.transform.position);
    }


    void FollowPlayer()
    {
        // Movimiento hacia el jugador
        Vector3 direction = (Player.transform.position - transform.position).normalized;
        transform.position += direction * speed * Time.deltaTime;
    }

}
