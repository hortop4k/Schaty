using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeBottle : MonoBehaviour
{
    public bool col;
    public GameObject BottleUi;
    public GameObject Bottle;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            col = true;
            Bottle.SetActive(false);
            BottleUi.SetActive(true);

        }
    }
}
