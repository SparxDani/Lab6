using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class look : MonoBehaviour
{
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        transform.LookAt(target, Vector3.left);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}