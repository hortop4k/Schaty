using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickObject : MonoBehaviour, IPickUpable
{
    public GameObject image;

    public GameObject GetIcon()
    {
        Debug.Log("hELLO");
        return image;   
        //Destroy(this.gameObject);
    }

    private void Start()
    {
        
    }
}
