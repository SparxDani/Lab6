using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidadMovimiento;
    public float velocidadGiro;
    public float velocidadInclinacion;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeRotation;
    }

    private void Update()
    {
        rb.velocity = transform.forward * velocidadMovimiento;

        float giroHorizontal = Input.GetAxis("Horizontal") * velocidadGiro * Time.deltaTime;
        float giroVertical = Input.GetAxis("Vertical") * velocidadGiro * Time.deltaTime;
        float inclinacion = Input.GetAxis("Inclinacion") * velocidadInclinacion * Time.deltaTime;

        transform.Rotate(0f, giroHorizontal, 0f, Space.Self);
        transform.Rotate(giroVertical, 0f, 0f, Space.Self);
        transform.Rotate(0f, 0f, inclinacion, Space.Self);
    }
}
