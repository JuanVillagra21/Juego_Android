using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlAcelerometro : MonoBehaviour
{
    // Puedes ajustar estos valores según sea necesario
    public float factorDeVelocidadX = 25.0f;
    public float factorDeVelocidadY = 25.0f;

    // Update is called once per frame
    void Update()
    {
        // Obtiene los valores del acelerómetro
        Vector3 dir = Vector3.zero;

        dir.x = -Input.acceleration.x;
        dir.y = Input.acceleration.y;
        dir.z = Input.acceleration.z;

        // Normaliza el vector de dirección si su magnitud es mayor que 1
        if (dir.sqrMagnitude > 1)
            dir.Normalize();

        dir *= Time.deltaTime;

        // Mueve el objeto en ambos ejes X e Y según los valores del acelerómetro
        transform.Translate(new Vector3(dir.x * factorDeVelocidadX, dir.y * -factorDeVelocidadY, 0));
    }

    // Obtiene el valor promedio del acelerómetro
    Vector3 GetAccelerometerValue()
    {
        Vector3 acc = Vector3.zero;
        float period = 0.0f;

        // Calcula el valor promedio del acelerómetro en un periodo de tiempo
        foreach (AccelerationEvent evnt in Input.accelerationEvents)
        {
            acc += evnt.acceleration * evnt.deltaTime;
            period += evnt.deltaTime;
        }

        // Normaliza el valor promedio
        if (period > 0)
        {
            acc *= 1.0f / period;
        }

        return acc;
    }
}