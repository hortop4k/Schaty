using OpenCover.Framework.Model;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PickUp : MonoBehaviour, IPickUpable
{
    private InvForPlayer inventory;
    public GameObject image;
    
    
    public static bool plus;
    public static GameObject objectImage;
    
    
    
    

    public GameObject GetIcon()
    {
        
        for (int i = 0; i < inventory.slots.Length; i++)
        {
            
            if (inventory.isFull[i] == false)
            {
                inventory.isFull[i] = true;
                Instantiate(image, inventory.slots[i].transform);
                plus = false;
                
                inventory.slots[i] = image;
                objectImage = image;
                Destroy(gameObject);


                break;
            }
            if (inventory.isFull[i] == true && inventory.slots[i] == image)
            {
                
                Debug.Log("+1");
                objectImage = image;
                Destroy(gameObject);
                plus = true;
                break;
            }
            
        }
        return image;
    }

    private void Start()
    {
        
        
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<InvForPlayer>();
    }
    
}
