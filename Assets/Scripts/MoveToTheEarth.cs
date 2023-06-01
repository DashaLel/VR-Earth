using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MoveToTheEarth : MonoBehaviour
{
    public float speed;
    private Transform target;
    public GameObject Earth;
    
    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Earth").GetComponent<Transform>();
       
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.time);
        transform.RotateAround(Earth.transform.position, Vector3.left, 5 * Time.deltaTime);
    }

}
