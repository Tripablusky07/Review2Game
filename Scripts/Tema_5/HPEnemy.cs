using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPEnemy : MonoBehaviour
{
    private float maxHealth = 100; // Salud máxima
    private float currentHealth = 100; // Salud actual
    private float damageBullet = 20; // Daño causado por el player
    [SerializeField] private Image lifeBar; // Objeto con la barra de salud
    [SerializeField] private ParticleSystem smallExplosion, bigExplosion; // Variables tipo Particle System se almacenan (inspector)



    void Awake()
    {
        smallExplosion.Stop(); // Reproducción detenida
        bigExplosion.Stop();
        currentHealth = maxHealth; // Inicialización de salud
        lifeBar.fillAmount = 1; // Inicialización barra de salud
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BalaPlayer")) { // Choca proyectil de player
            smallExplosion.Play(); // Reproducción partículas
            currentHealth -= damageBullet; // Actualización daño
            lifeBar.fillAmount = currentHealth / maxHealth; // Actualización barra salud
            Destroy(other.gameObject); // Destrucción
            if (currentHealth <= 0)
            { // SI la salud es 0 o inferior
                Death(); //llamamos metodo death
            }
        }
    }




    private void Death() //Funcion muerte
    {
        bigExplosion.Play(); // Reproducción partículas
        Destroy(gameObject, 1.0f); // Destruimos al enemigo
    }








}
