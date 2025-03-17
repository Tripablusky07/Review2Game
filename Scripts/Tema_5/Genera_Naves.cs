using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Genera_Naves : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab; // Almacenar el prefab del enemigo
    [SerializeField] private Transform[] posRotEnemy; //posicion y rotacion emptyObject, se almacena
    [SerializeField] private int maxEnemies = 4; // L�mite m�ximo de enemigos que pueden generarse
    private float timeBetweenEnemies = 5.0f; // A�adimos la variable que define el intervalos de tiempo entre clonaciones
    private int enemyCount = 0; // Contador de enemigos generados
    [SerializeField] private float pauseTime = 15.0f; // Tiempo de pausa antes de reiniciar la generaci�n

    private void CreateEnemies() //El m�todo para instanciar enemigos utilizar� las posiciones de forma aleatoria:
    {
        if (enemyCount < maxEnemies)
        {
            int n = Random.Range(0, posRotEnemy.Length); // aleatoriza la posicion y rotacion del posrotEnemy (vacioEmpty)
            Instantiate(enemyPrefab, posRotEnemy[n].position, posRotEnemy[n].rotation);
            enemyCount++; // Incrementa el contador de enemigos generados
        }
        else
        {
            CancelInvoke("CreateEnemies"); // Detiene la invocaci�n repetida cuando se alcanza el l�mite
            Invoke("RestartEnemyGeneration", pauseTime); // Inicia una pausa antes de reiniciar la generaci�n
        }
    }

    private void RestartEnemyGeneration()
    {
        enemyCount = 0; // Reinicia el contador de enemigos
        InvokeRepeating("CreateEnemies", 1.0f, timeBetweenEnemies); // Reanuda la generaci�n de enemigos
    }




    void Start()
    {
        InvokeRepeating("CreateEnemies", 1.0f, timeBetweenEnemies); //invocamos el m�todo de forma repetida con un intervalo de tiempo
    }


}



