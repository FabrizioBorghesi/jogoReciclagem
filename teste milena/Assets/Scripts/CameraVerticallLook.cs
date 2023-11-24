using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraVerticalLook : MonoBehaviour
{
    public float sensitivity = 2f; // Sensibilidade do movimento do mouse

    float verticalRotation = 0f;

    void Update()
    {
        // Obter a entrada do mouse
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        // Rotação vertical (olhar para cima e para baixo)
        verticalRotation -= mouseY;
        verticalRotation = Mathf.Clamp(verticalRotation, -90f, 90f); // Limitar a rotação vertical

        // Aplicar rotação vertical ao objeto da câmera
        transform.localRotation = Quaternion.Euler(verticalRotation, 0f, 0f);
    }
}
