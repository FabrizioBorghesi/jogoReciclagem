using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHorizontalLook : MonoBehaviour
{
    public float sensitivity = 2f; // Sensibilidade do movimento do mouse

    void Update()
    {
        // Obter a entrada do mouse
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;

        // Aplicar rotação horizontal ao objeto do jogador
        transform.Rotate(Vector3.up * mouseX);
    }
}
