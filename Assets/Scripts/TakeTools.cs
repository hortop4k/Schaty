using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeTools : MonoBehaviour
{
    public GameObject kirkaEnviroment;
    public GameObject kirkaPlayer;
    public static bool toolInHand;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Destroy(kirkaEnviroment);
            var iconic = kirkaEnviroment.GetComponent<IPickUpable>();
            if(iconic != null )
            {
                iconic.GetIcon();
            }
            kirkaPlayer.SetActive(true);
            toolInHand = true;

        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C) && !toolInHand)
        {
            kirkaPlayer.SetActive(true);
            toolInHand = true;
        }
        if (Input.GetKeyDown(KeyCode.C) && toolInHand)
        {
            kirkaPlayer.SetActive(false);
            toolInHand = false;
        }
    }
}
