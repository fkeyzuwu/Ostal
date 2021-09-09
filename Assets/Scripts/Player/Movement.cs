using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private new Rigidbody rigidbody;
    [SerializeField] private float maximumVelocity = 10f;
    [SerializeField] private float speed = 100f;
    public void Move()
    {
        if (rigidbody.velocity.magnitude >= maximumVelocity) return;

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 direction = transform.right * x + transform.forward * z;
        rigidbody.AddForce(speed * direction);
    }
}
