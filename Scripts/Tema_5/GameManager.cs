    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]private GameObject panelGameOver;
    [SerializeField] private Genera_Naves enemyManager;


    public void GameOver()
    {
        panelGameOver.SetActive(true); //activa el panel
        enemyManager.enabled = false;
        Cursor.lockState = CursorLockMode.Confined; //Desbloquea la vision del cursor
    }


    public void LoadSceneLevel()
    {
        SceneManager.LoadScene("Tema_5"); //carga la escena
    }


    public void Salir()
    {
        Debug.Log("Saliendo del juego...");
        Application.Quit(); // Cierra la aplicación
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // Detiene el modo Play en el editor
#endif
    }
}
