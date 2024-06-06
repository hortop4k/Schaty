using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading;

public class eventNight : MonoBehaviour
{
    public Action DayAction;
    public static Action NigthAction;
    public float TimeDay;

    private void FixedUpdate()
    {
        TimeDay += Time.deltaTime;
        if (TimeDay >= 360)
        {
            TimeDay = 0;
        }
        transform.localRotation = Quaternion.Euler(TimeDay, 180, 0);
        if (TimeDay > 180 && TimeDay < 355)
        {
            NigthAction?.Invoke();
            Debug.Log("Night");
        }
        else
        {
            DayAction?.Invoke();
            Debug.Log("Day");
        }



        //for(int i = 0; i < 360; i+=10)
        // {
        //     transform.Rotate(i * Time.deltaTime, 0, 0);


        //     if  (transform.rotation.x > 90 && transform.rotation.x < 300) //ночь
        //     {

        //         Debug.Log("Night");
        //     }
        //     else if (transform.rotation.x > 300 || transform.rotation.x < 90)
        //     {

        //         Debug.Log("Day");
        //     }

        // }

        // transform.Rotate(0, 0, 0);




        //for (int i = 0; i < 360; i++)
        //{
        //    transform.Rotate(0, i * Time.deltaTime, 0);
        //    if (i < -43 && i > -233) //если ночь
        //    {
        //        NigthAction?.Invoke();
        //        Debug.Log("Night");
        //    }
        //    else //день
        //    {
        //        DayAction?.Invoke();
        //        Debug.Log("Day");
        //    }
        //}
    }

   

}
