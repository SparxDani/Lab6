using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPlanetas : MonoBehaviour
{
    public float velocidadRotacion;
    public Transform planetaOrbitado;

    void Update()
    {
        transform.Rotate(Vector3.up * velocidadRotacion * Time.deltaTime);

        transform.RotateAround(planetaOrbitado.position, Vector3.up, velocidadRotacion * Time.deltaTime);
    }
}
