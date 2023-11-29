using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColisionConJugador : MonoBehaviour
{
    // Puedes ajustar el nombre del tag seg�n el que hayas asignado al objeto vac�o
    public string spawnPointTag = "SpawnPoint";

    public List<string> escenasPerdiste; // Lista de nombres de escenas de "perdiste"

    private void OnTriggerEnter(Collider collision)
    {
        // Verifica si la colisi�n involucra al jugador
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Colisi�n con el jugador");

            // Ejemplo: destruir el objeto del spawn point
            if (transform.CompareTag(spawnPointTag))
            {
                Destroy(gameObject);
            }

            CargarEscenaPerdisteAleatoria();
        }
    }

    private void CargarEscenaPerdisteAleatoria()
    {
        if (escenasPerdiste.Count > 0)
        {
            // Obtener un �ndice aleatorio para elegir la escena
            int indiceEscena = Random.Range(0, escenasPerdiste.Count);

            // Obtener el nombre de la escena seleccionada
            string nombreEscenaSeleccionada = escenasPerdiste[indiceEscena];

            // Cambiar a la escena seleccionada
            SceneManager.LoadScene(nombreEscenaSeleccionada);
        }
        else
        {
            Debug.LogError("La lista de escenas de 'perdiste' est� vac�a. A�ade al menos una escena.");
        }
    }
}
