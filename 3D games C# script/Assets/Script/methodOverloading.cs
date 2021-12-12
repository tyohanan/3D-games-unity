using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class methodOverloading : MonoBehaviour
{

    void Start() {
        Fun fun = new Fun();
        // fun.printFloat(2.5f);
        // fun.printInt(2);
        // fun.printString("Raja");
        fun.Print(24);
        fun.Print("niceway to die", 25);
    }

}


public class Fun {
    public void printInt(int i){
        Debug.Log(i);
    }

    public void printFloat(float i){
        Debug.Log(i);
    }

    public void printString(string i){
        Debug.Log(i);
    }

    public void printBool(bool i)
    {
        Debug.Log(i);
    }

    public void Print(float i){
        Debug.Log("print (float i)");
    }

    public void Print(string i){
        Debug.Log("print (string i)");
    }

    public void Print(string i, float j){
        Debug.Log("print 2 variable string and float");
    }
}