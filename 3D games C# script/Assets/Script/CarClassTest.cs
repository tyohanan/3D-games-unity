using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarClassTest : MonoBehaviour
{
    private Car myCar;
    private Car suzuki;

    private void Start()
    {
        suzuki = new Car(20f, "blue", 10);
    }

    private void Update()
    {
        // Debug.Log(suzuki.speed + suzuki.color + suzuki.highestSpeed);
    }
}
