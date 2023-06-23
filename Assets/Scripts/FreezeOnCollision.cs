using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeOnCollision : MonoBehaviour
{
    private Rigidbody arrowRigidbody;
    private void Start()
    {
        arrowRigidbody = GetComponent<Rigidbody>();
        arrowRigidbody.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.rigidbody != null && collision.rigidbody.CompareTag("Target"))
        {
            transform.SetParent(collision.transform);
            arrowRigidbody.isKinematic = true; 
            arrowRigidbody.constraints = RigidbodyConstraints.FreezeAll;
            Debug.Log("arrow collided with" + name);
        }
    }
}

