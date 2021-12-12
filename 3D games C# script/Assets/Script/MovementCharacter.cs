using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using usingNamespace;
using usingNamespace.UI;

public class MovementCharacter : MonoBehaviour
{
    public GameObject target;

    private void Start(){
        Utilities.PrintCharger();
        UIStuff.DoUI();
    }
    private void Update()
    {
        transform.LookAt(target.transform.position, Vector3.up);
    }
}
