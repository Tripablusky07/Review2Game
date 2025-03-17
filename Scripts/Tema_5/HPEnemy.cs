using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPEnemy : MonoBehaviour
{
    private float maxHealth = 100; // Salud m�xima
    private float currentHealth = 100; // Salud actual
    private float damageBullet = 20; // Da�o causado por el player
    [SerializeField] private Image lifeBar; // Objeto con la barra de salud
    [SerializeField] private ParticleSystem smallExplosion, bigExplosion; // Variables tipo Particle System se almacenan (inspector)



    void Awake()
    {
        smallExplosion.Stop(); // Reproducci�n detenida
        bigExplosion.Stop();
        currentHealth = maxHealth; // Inicializaci�n de salud
        lifeBar.fillAmount = 1; // Inicializaci�n barra de salud
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BalaPlayer")) { // Choca proyectil de player
            smallExplosion.Play(); // Reproducci�n part�culas
            currentHealth -= damageBullet; // Actualizaci�n da�o
            lifeBar.fillAmount = currentHealth / maxHealth; // Actualizaci�n barra salud
            Destroy(other.gameObject); // Destrucci�n
            if (currentHealth <= 0)
            { // SI la salud es 0 o inferior
                Death(); //llamamos metodo death
            }
        }
    }




    private void Death() //Funcion muerte
    {
        bigExplosion.Play(); // Reproducci�n part�culas
        Destroy(gameObject, 1.0f); // Destruimos al enemigo
    }








}
