using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MIneralsExtraction : MonoBehaviour
{
    public float TimeToDestroy;
    private GameObject MinPrefab;
    void Start()
    {
        
    }

    
    void Update()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, 20) && hit.collider.tag == "Minerals")
        {
            if (Input.GetMouseButton(0))
            {
                TimeToDestroy += Time.deltaTime;
                if (TimeToDestroy >= 5)
                {
                    MinPrefab = GameObject.FindGameObjectWithTag("Minerals");
                    Destroy(MinPrefab);
                }
            }
            else
            {
                TimeToDestroy = 0;
            }
                
            
            
        }
        else
        {
            TimeToDestroy = 0;
        }
    }
}
