using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [SerializeField] private new Transform camera;

    [SerializeField] private float mouseSensitivity = 100f;
    [SerializeField] private float xRotation = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            if(Cursor.lockState == CursorLockMode.Locked)
            {
                Cursor.lockState = CursorLockMode.None;
            }
            else
            {
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
    }

    public void Look()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.Rotate(Vector3.up * mouseX);
        camera.localRotation = Quaternion.Euler(xRotation , 0f, 0f);
    }
}
