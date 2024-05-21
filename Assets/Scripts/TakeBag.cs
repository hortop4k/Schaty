using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeBag : MonoBehaviour
{
    public GameObject Bag;
    public static bool takingBag;
    
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
            takingBag = true;
            Bag.SetActive(false);
            

        }
    }
}
