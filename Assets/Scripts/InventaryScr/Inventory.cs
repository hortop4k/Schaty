using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private Canvas canvas;
    private bool inv = false;
    void Start()
    {
        canvas = GetComponent<Canvas>();
        canvas.enabled = false;
    }

    
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.I) && TakeBag.takingBag && !inv)
        {
            canvas.enabled = true;
            inv = true;

            

        }
        
        
        if (Input.GetKeyDown(KeyCode.I) && inv)
        {
            canvas.enabled = false ;
            inv = false;
            StartCoroutine(TimeToInv());
        }
    }
   
    private IEnumerator TimeToInv()
    {
        inv = true;
        yield return new WaitForSeconds(1);
        inv = false;
    }
}
