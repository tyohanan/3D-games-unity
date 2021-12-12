using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Car
{
    public float speed;
    public string color;
    public int highestSpeed;

    public Car(float speed, string color, int highestSpeed)
    {
        this.speed = speed;
        this.color = color;
        this.highestSpeed = highestSpeed;
    }

    //public void Move(){
    //    Debug.Log(speed+" "+color+" "+highestSpeed);
    //}

    //public void ApplyBrake() {
    //    Debug.Log("Braking");
    //}




}
