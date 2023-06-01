using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketMoveFoward : MonoBehaviour
{
    public float speed;


    
    void Update()
    {
        transform.Translate(Vector3.up * Time.time * speed);
    }
}
