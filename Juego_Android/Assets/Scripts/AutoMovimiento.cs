using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMovimiento : MonoBehaviour
{
    public float velocidad = 5.0f; // Velocidad de movimiento del auto
    public float tiempoDeVida = 10.0f; // Tiempo antes de que el auto desaparezca

    private List<IMovimientoAdicional> movimientosAdicionales = new List<IMovimientoAdicional>();

    void Start()
    {
        // Comienza a contar el tiempo hasta que el auto deba desaparecer
        Invoke("DesaparecerAuto", tiempoDeVida);

        // Añadir cualquier nuevo movimiento adicional aquí
        movimientosAdicionales.Add(new MovimientoAbajo());
    }

    void Update()
    {
        foreach (var movimientoAdicional in movimientosAdicionales)
        {
            movimientoAdicional.Mover(gameObject, velocidad);
        }
    }

    void DesaparecerAuto()
    {
        // Agregar aquí el código para hacer que el auto desaparezca
        Destroy(gameObject);
    }
}

// Definición de la interfaz para movimientos adicionales
public interface IMovimientoAdicional
{
    // Método que debe implementarse para realizar un movimiento adicional
    void Mover(GameObject gameObject, float velocidad);
}

// Implementación específica de un movimiento adicional (en este caso, mover hacia abajo)
public class MovimientoAbajo : IMovimientoAdicional
{
    // Implementación del método de la interfaz para mover hacia abajo
    public void Mover(GameObject gameObject, float velocidad)
    {
        // Mueve el objeto hacia abajo en el eje Y
        gameObject.transform.Translate(Vector3.down * velocidad * Time.deltaTime);
    }
}
