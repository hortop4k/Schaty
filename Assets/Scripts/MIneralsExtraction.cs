using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class MIneralsExtraction : MonoBehaviour
{
    public float TimeToDestroy;
    [SerializeField] private GameObject MinPrefab;
    public static bool Destr;
    private InvForPlayer inventory;
    [SerializeField] private int[] count = new int[] {0};
    public TMP_Text[] countText;
    public GameObject[] Texting;
    public int number;
    public GameObject massiveInvent;
    public GameObject kirka;



    void Start()
    {
        inventory = GetComponent<InvForPlayer>();
    }

    
    void Update()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, 20) && hit.collider.tag == "Minerals" && TakeTools.toolInHand)
        {
            if (Input.GetMouseButton(0))
            {

                MinPrefab = hit.collider.gameObject;
                  
                

                TimeToDestroy += Time.deltaTime;
                if (TimeToDestroy >= 3)
                {
                    var iconic = hit.collider.gameObject.GetComponent<IPickUpable>();
                    
                    if (iconic != null)
                    {
                        iconic.GetIcon();
                        Destr = true;
                        
                            InventStack();
                            
                        
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
    public void InventStack()
    {
        for (int i = 0; i < inventory.slots.Length; i++)
        {

            if (inventory.slots[i] == PickUp.objectImage)
            {
                Debug.Log("plus");
                Texting[i].SetActive(true);
                //count[i]++;
                number = count[i];
                number++;
                count[i] = number;
                countText[i].text = count[i].ToString();
                break;
            }
            else
            {
                Debug.Log("Wops");  
            }

        }
    }


}
