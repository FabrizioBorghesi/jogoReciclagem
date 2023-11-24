using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 20f; // Velocidade de movimentação do personagem

    void Update()
    {
        // Obtém os valores de entrada horizontal e vertical (teclas A/D ou setas esquerda/direita, W/S ou setas cima/baixo)
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Calcula a direção de movimentação com base nos valores de entrada
        Vector3 moveDirection = new Vector3(horizontal, 0f, vertical).normalized;

        // Move o personagem na direção calculada
        transform.Translate(moveDirection * speed * Time.deltaTime);
    }
}
