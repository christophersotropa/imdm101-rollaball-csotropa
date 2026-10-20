using UnityEngine;
using System;


public class Clock1 : MonoBehaviour
{
    [SerializeField]

    Transform hourPivot, minutePivot, secondPivot;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Started");

    }

    // Update is called once per frame
    void Update()
    {
        hourPivot.localRotation = Quaternion.Euler(0.0f, 0.0f, -30f * DateTime.Now.Hour);      
        minutePivot.localRotation = Quaternion.Euler(0.0f, 0.0f, -6f * DateTime.Now.Minute);      
        secondPivot.localRotation = Quaternion.Euler(0.0f, 0.0f, -6f * DateTime.Now.Second);      
    }
}
