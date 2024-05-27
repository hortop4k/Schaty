using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour, IPickUpable
{
    private InvForPlayer inventory;
    public GameObject image;

    public GameObject GetIcon()
    {
        Debug.Log("hELLO");
        //return image;
        //Destroy(this.gameObject);
        for (int i = 0; i < inventory.slots.Length; i++)
        {
            if (inventory.isFull[i] == false)
            {

                inventory.isFull[i] = true;
                Instantiate(image, inventory.slots[i].transform);
                Destroy(gameObject);
                break;
            }

        }
        return image;
    }

    private void Start()
    {
        
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<InvForPlayer>();
    }

    public void Update()
    {

        //if (MIneralsExtraction.Destr)
        //{
        //    for (int i = 0; i < inventory.slots.Length; i++)
        //    {
        //        if (inventory.isFull[i] == false)
        //        {
                    
        //            inventory.isFull[i] = true;
        //            Instantiate(image, inventory.slots[i].transform);
        //            //Destroy(gameObject);
        //            MIneralsExtraction.Destr = false;
        //            break;
        //        }
        //    }
        //}
    }
    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.tag == "Player")
    //    {

    //        for (int i = 0; i < inventory.slots.Length; i++)
    //        {
    //            if (inventory.isFull[i] == false)
    //            {

    //                inventory.isFull[i] = true;
    //                Instantiate(image, inventory.slots[i].transform);
    //                Destroy(gameObject);
    //                break;
    //            }
    //        }
    //    }
    //}

}
