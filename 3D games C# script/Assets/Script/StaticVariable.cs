using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticVariable : MonoBehaviour
{

    public static int a;

    private void Start()
    {
        a++;
        
        Bullets bullet1 = new Bullets();
        Bullets.noOfBullets = 10;

        Bullets bullet2 = new Bullets();
        Bullets.noOfBullets = 20;

        print(Bullets.noOfBullets);
        print(Bullets.noOfBullets);
    }
}

public class Bullets
{
    public static int noOfBullets= 0;

    public Bullets(){
        noOfBullets++;
    }

    public static void Showbullets(){
        Debug.Log("No bullets in the gun "+ noOfBullets);
    }
}