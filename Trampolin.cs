using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampolin : MonoBehaviour
{
    public float TrampolineForce = 2f;
    public Rigidbody PlayerTrampoline;

    private void Start()
    {
        PlayerTrampoline = GameObject.Find("Player").GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            PlayerTrampoline.AddForce(Vector3.up * TrampolineForce);
    }
}