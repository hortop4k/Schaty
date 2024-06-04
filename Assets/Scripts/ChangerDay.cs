using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangerDay : MonoBehaviour
{
   
    [SerializeField] GameObject lighting;

    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Rotate(0, Time.deltaTime, 0);
    }
}
