using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VolverAlMenu : MonoBehaviour
{
    // Este script se encarga de cargar la escena del men� inicial

    // M�todo llamado al hacer clic en un bot�n que activa el regreso al men� inicial
    public void IrAInicio()
    {
        // Utiliza el SceneManager para cargar la escena del men� inicial
        SceneManager.LoadScene("MenuInicial"); // Reemplaza con el nombre de tu escena de inicio
    }
}