using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public GameObject player;
    private float verticalLookRotation = 0f;


    // Update is called once per frame
    void Update()
    {
        //get mouse input
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY= Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        //rotate player gameObject with horizontal mouse input
        player.transform.Rotate(Vector3.up * mouseX);

        //rotate camera around x axis with vertical mouse input
        verticalLookRotation -= mouseY;

        verticalLookRotation = Mathf.Clamp(verticalLookRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(verticalLookRotation, 0f, 0f);

    }

    private void OnApplicationFocus(bool Focus)
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
}
