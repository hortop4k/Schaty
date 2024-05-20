using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeWater : MonoBehaviour
{
    public GameObject water;
    public float timer;
    
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            timer += Time.deltaTime;

            

        }

    }
    private void OnTriggerExit(Collider other)
    {
        timer = 0;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && timer > 0)
        {
            water.SetActive(true);
        }
    }
    
}
