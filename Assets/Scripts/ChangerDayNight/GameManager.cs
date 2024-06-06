using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject objects;
    private void OnEnable()
    {
        eventNight.NigthAction += Nighting;
    }
    private void OnDisable()
    {
        eventNight.NigthAction -= Nighting;
    }

    private void Nighting()
    {
        Instantiate(objects, new Vector3(-1, 25, 107), Quaternion.Euler(-90, 0 , 0));
    }
}
