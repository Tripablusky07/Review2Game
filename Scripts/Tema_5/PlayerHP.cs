using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    [SerializeField] private float maxHealth = 100; //vida max
    private float currentHealth = 100; //vida actual
    private float damageBullet = 5; //da�o de bala
    [SerializeField] private Image lifeBar; //almacena objeto con la barra de vida
    [SerializeField] private ParticleSystem bigExplosion; // Almacena Particulas (inspector)
    [SerializeField] private ParticleSystem smallExplosion;
    [SerializeField] private GameManager Manager;//Se almacena el emptyVacio llamado Manager junto a sus scripts


    
    void Awake()
    {


        bigExplosion.Stop(); //detiene las particulas
        smallExplosion.Stop();


        currentHealth = maxHealth;
        lifeBar.fillAmount = 1; // Actualizaci�n de la vida // 1 esta lleno, 0 esta vacio

    }



    private void Death()
    {

        Camera.main.transform.SetParent(null); // Antes de destruir el objeto deshacer la jerarqu�a
        Destroy(gameObject); // Camera.main es la c�mara con el 
                             // tag "MainCamera"
        Manager.GameOver(); //llama al metodo GameOver
    }


    private void OnTriggerEnter(Collider other)
    {




        if (other.CompareTag("BalaEnemigo"))
        {

            smallExplosion.Play(); //reproducir particula

            Debug.Log("te han disparado");//comprobar el impacto

            currentHealth -= damageBullet; // Da�o causado // que seria lo mismo currenthealth - damaguebullet (vida actual - da�o de bala)
            lifeBar.fillAmount = currentHealth / maxHealth; // C�lculo de la salud
            Destroy(other.gameObject); // Destruimos el proyectil
            if (currentHealth <= 0) // Comprobamos si hemos muerto
            {
                bigExplosion.Play();
                Death(); //llamamos al metodo death
            }

        
            
        }

       
    }
}
