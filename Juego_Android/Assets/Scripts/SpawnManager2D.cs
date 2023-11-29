using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager2D : MonoBehaviour
{
    public GameObject carPrefab; // Arrastra aquí el Prefab del auto en 2D
    public List<Transform> spawnPoints; // Lista de objetos Transform que representan los puntos de spawn
    public float spawnInterval = 3.0f; // Intervalo de tiempo entre spawns

    private void Start()
    {
        StartCoroutine(SpawnCar());
    }

    // Método para spawnear autos de manera continua
    IEnumerator SpawnCar()
    {
        while (true) // Esto hará que los autos se sigan spawnendo indefinidamente
        {
            int randomIndex = Random.Range(0, spawnPoints.Count); // Elije un punto de spawn aleatorio
            Transform spawnPoint = spawnPoints[randomIndex];

            Instantiate(carPrefab, spawnPoint.position, Quaternion.identity);

            yield return new WaitForSeconds(spawnInterval);
        }
    }
}