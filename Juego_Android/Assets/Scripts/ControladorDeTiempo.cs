using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorDeTiempo : MonoBehaviour
{
    public float tiempoLimite = 35.0f;
    private float tiempoRestante;
    public TextMeshProUGUI mensajeVictoria; // Referencia al objeto de texto de victoria

    public delegate void VictoriaEventHandler();
    public event VictoriaEventHandler OnVictoria;

    private void Start()
    {
        tiempoRestante = tiempoLimite;
        mensajeVictoria.gameObject.SetActive(false); // mensaje de victoria esté desactivado al inicio
    }

    private void Update()
    {
        tiempoRestante -= Time.deltaTime;

        if (tiempoRestante <= 0)
        {
            GanarJuego();
        }
    }

    private void GanarJuego()
    {
        // El jugador ha ganado el juego
        OnVictoria?.Invoke();
        MostrarMensajeDeVictoria(); // Llama a la función para mostrar el mensaje
    }

    private void MostrarMensajeDeVictoria()
    {
        mensajeVictoria.gameObject.SetActive(true); // Activa el mensaje de victoria

        // Carga la escena de victoria después de un breve retraso (por ejemplo, después de 3 segundos)
        Invoke("CargarEscenaDeVictoria", 3.0f);
    }

    private void CargarEscenaDeVictoria()
    {
        SceneManager.LoadScene("Victoria"); // Carga la escena de victoria
    }
}