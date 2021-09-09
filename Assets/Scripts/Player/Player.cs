using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Player : NetworkBehaviour
{
    [SerializeField] private Movement movement;
    [SerializeField] private MouseLook mouseLook;

    void FixedUpdate()
    {
        movement.Move();
    }

    void LateUpdate()
    {
        mouseLook.Look();
    }
}
