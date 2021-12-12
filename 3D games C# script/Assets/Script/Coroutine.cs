using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutine : MonoBehaviour
{
    public GameObject cube;
    private void Start() {
        // StartCoroutine("Test");
        // Test2();
        StartCoroutine("Test3", 4);
        for(int i = 0; i < 6; i++){
            print("Start()");
        }
        StopCoroutine("Test3");

    }

    private void Update() {
        
    }

    IEnumerator Test(){
        print(" Coroutine Start");

        yield return new WaitForSeconds(5f);

        cube.GetComponent<Renderer>().material.color = Color.red;

        yield return new WaitForSeconds(2f);
        
        cube.GetComponent<Renderer>().material.color = Color.green;

        yield return null;

        print(" coroutine Ends");

    }

    void Test2(){
        for(int i = 0; i < 6; i++){
            print("Test 2()");
        }
    }

    IEnumerator Test3(int Times){
        for(int i = 0; i < Times; i++){
          print("Test 3()");

          yield return null;
        }
    }


}
