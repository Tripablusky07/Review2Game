using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{

    private int speed = 50; //velocidad de movimiento
    private int turnSpeed = 125; //velocidad de rotación



    private void Awake()
    {
        
        Cursor.lockState = CursorLockMode.Locked; // Bloquear vision cursor

    }

    private void Movement()
    {


        // Captura la entrada del teclado (WASD)
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Definir la dirección de movimiento
        Vector3 direction = new Vector3(horizontal, 0, vertical);

        //Aplicar transformaciones para el movimiento
        transform.Translate(direction.normalized * speed * Time.deltaTime);



}

    private void Turning() //Giro
    {

        // Captura la entrada del ratón para rotación
        float xMouse = Input.GetAxis("Mouse X"); // Movimiento horizontal del ratón
        float yMouse = Input.GetAxis("Mouse Y");// Movimiento vertical del ratón

        // Calcula la rotación basada en la entrada del ratón
        Vector3 rotation = new Vector3(-yMouse, xMouse, 0);

        // Aplica la rotación del jugador
        transform.Rotate(rotation.normalized * turnSpeed * Time.deltaTime);


    }



    void Update() //Actualiza los metodos por segundo
    {
        Movement();
        Turning();
    }
}
