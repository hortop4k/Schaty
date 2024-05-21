using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeWater : MonoBehaviour
{
    public GameObject water;
    public float timer;
    public GameObject freeBottle;
    public static bool fullness = false;
    
    

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
        Drink();
        if (Input.GetKeyDown(KeyCode.E) && timer > 0)
        {
            water.SetActive(true);
            freeBottle.SetActive(false);
            fullness = true;
        }
    }
    public void Drink()
    {
        if (Input.GetKeyDown(KeyCode.F) && fullness)
        {
            fullness = false;
            freeBottle.SetActive(true);
            water.SetActive(false);
        }
    }

}
