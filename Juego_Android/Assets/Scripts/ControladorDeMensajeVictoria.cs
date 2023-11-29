using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorDeMensajeVictoria : MonoBehaviour
{
    // Evita que el objeto asociado se destruya al cargar una nueva escena
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
