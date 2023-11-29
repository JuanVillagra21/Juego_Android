using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{
    // Método para cargar la siguiente escena cuando el jugador decide jugar
    public void Jugar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Método para salir de la aplicación
    public void Salir()
    {
        Debug.Log("Salir..."); // Mensaje de depuración
        Application.Quit(); // Cierra la aplicación
    }
}