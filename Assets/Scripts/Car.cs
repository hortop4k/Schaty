using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public float speed = -5.0f;
    public Rigidbody rb;
    void Update()
    {
       rb.AddForce(0,0,speed);
    }
}
