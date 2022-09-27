using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        EventManager.BadPickup += FallDown;
    }

    private void FallDown()
    {
        _rigidbody.useGravity = true;
    }
}
