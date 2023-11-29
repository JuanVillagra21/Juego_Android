using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{
    // M�todo para cargar la siguiente escena cuando el jugador decide jugar
    public void Jugar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // M�todo para salir de la aplicaci�n
    public void Salir()
    {
        Debug.Log("Salir..."); // Mensaje de depuraci�n
        Application.Quit(); // Cierra la aplicaci�n
    }
}