using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TakeResources : MonoBehaviour
{
    public TMP_Text xp;
    public bool col = false;
    public GameObject res;
    public Image XPBar;
    private float AddXp = 0.8f;
    [SerializeField] private float OverXp;
    public TMP_Text Lvl;
    private float AddLvl = 1;
    private float AboveLvlCount;
    private float SecondOverXp;
    [SerializeField] private float LimitLvl = 1;
    [SerializeField] private float per = 1;
    

    private void Start()
    {
        xp.enabled = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Resources")
        {
            col = true;
            
            res = other.gameObject;
            
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Resources")
        {
            col = false;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && col)
        {
           Destroy(res);
            xp.enabled = true;
            StartCoroutine(TimeXP());
            
        }
    }
    private IEnumerator TimeXP()
    {
        col = false;
        OverXp += AddXp;
        SecondOverXp = OverXp;
        
        if (OverXp >= LimitLvl)
        {
            OverXp = 0;
            AboveLvlCount = SecondOverXp - per / LimitLvl;
            AddLvl += 1;
            OverXp += AboveLvlCount;
            XPBar.fillAmount = 0;
            LimitLvl += LimitLvl / 100 * 175;
            XPBar.fillAmount += OverXp / LimitLvl;
            Lvl.text = AddLvl.ToString();
        }
        else
        {
            Debug.Log(OverXp / LimitLvl);
            XPBar.fillAmount = OverXp / LimitLvl;
            Lvl.text = AddLvl.ToString();
        }
        
        yield return new WaitForSeconds(2);
        xp.enabled = false;
        
        AboveLvlCount = 0;
        
    }
    
}
