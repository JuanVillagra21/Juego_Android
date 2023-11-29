using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColisionConJugador : MonoBehaviour
{
    // Puedes ajustar el nombre del tag según el que hayas asignado al objeto vacío
    public string spawnPointTag = "SpawnPoint";

    public List<string> escenasPerdiste; // Lista de nombres de escenas de "perdiste"

    private void OnTriggerEnter(Collider collision)
    {
        // Verifica si la colisión involucra al jugador
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Colisión con el jugador");

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
            // Obtener un índice aleatorio para elegir la escena
            int indiceEscena = Random.Range(0, escenasPerdiste.Count);

            // Obtener el nombre de la escena seleccionada
            string nombreEscenaSeleccionada = escenasPerdiste[indiceEscena];

            // Cambiar a la escena seleccionada
            SceneManager.LoadScene(nombreEscenaSeleccionada);
        }
        else
        {
            Debug.LogError("La lista de escenas de 'perdiste' está vacía. Añade al menos una escena.");
        }
    }
}
