using UnityEngine;

public class Normalizacion : MonoBehaviour
{
    [SerializeField] private Transform tank;
    [SerializeField] private Transform robot;

    [SerializeField] private float velocidadMovimiento = 5f;

    void Update()
    {
        if (tank == null || robot == null) return;

        Vector3 direccion = robot.position - tank.position;

        if (direccion.sqrMagnitude > 0.001f) // evita normalizar un vector casi cero
        {
            tank.position += direccion.normalized * velocidadMovimiento * Time.deltaTime;
        }
    }
}