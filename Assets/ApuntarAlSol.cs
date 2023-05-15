using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApuntarAlSol : MonoBehaviour
{
    public Transform sol;

    void Update()
    {
        transform.LookAt(sol);
    }
}
