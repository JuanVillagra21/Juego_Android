using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VolverAlMenu : MonoBehaviour
{
    // Este script se encarga de cargar la escena del menú inicial

    // Método llamado al hacer clic en un botón que activa el regreso al menú inicial
    public void IrAInicio()
    {
        // Utiliza el SceneManager para cargar la escena del menú inicial
        SceneManager.LoadScene("MenuInicial"); // Reemplaza con el nombre de tu escena de inicio
    }
}