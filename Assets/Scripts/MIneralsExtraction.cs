using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MIneralsExtraction : MonoBehaviour
{
    public float TimeToDestroy;
    [SerializeField] private GameObject MinPrefab;
    public static bool Destr;
    
    

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

                MinPrefab = hit.collider.gameObject;
                //MinPrefab = MonoBehaviour as IPickUpable; 
                

                TimeToDestroy += Time.deltaTime;
                if (TimeToDestroy >= 5)
                {
                    var iconic = hit.collider.gameObject.GetComponent<IPickUpable>();
                    //MinPrefab = GameObject.FindGameObjectWithTag("Minerals");
                    if (iconic != null )
                    {
                        iconic.GetIcon();
                        //Destroy(MinPrefab);
                        Destr = true;
                    }
                    
                    
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
