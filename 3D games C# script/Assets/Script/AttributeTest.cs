using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class AttributeTest : MonoBehaviour
{
    public int speedPublic;

    [SerializeField]
    private int speedPrivate;

    [HideInInspector]
    public int speedHide;

    [Range(0,20)]
    public int speedRange;

    Rigidbody rb;

    private void Start() {
        rb = GetComponent<Rigidbody>();
    }

    private void Update() {
        rb.isKinematic = false;

    }
}
