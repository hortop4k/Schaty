using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Experimental.GraphView.GraphView;

public class BarWater : MonoBehaviour
{
    public Image Bar;
    private float WatFull = 100f;
    public float timer;
    private float AmountWater = 0.5f;
    void Start()
    {
        TimesNew();
    }

    
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.F) && TakeWater.fullness)
        {
            Bar.fillAmount += AmountWater;
            WatFull = Bar.fillAmount * 100;
            
        }
        Bar.fillAmount = WatFull / 100;
        
    }
    void TimesNew()
    {
        StartCoroutine(Timing());
    }
    private IEnumerator Timing()
    {
        WatFull -= 1;
        yield return new WaitForSeconds(1);
        TimesNew();
    }
    
}
