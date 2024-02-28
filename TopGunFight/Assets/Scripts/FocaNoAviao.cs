using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FocaNoAviao : MonoBehaviour
{
    public Transform aviao; // O objeto em movimento que queremos focar
    public float velocidadeRotacao = 5.0f; // Velocidade de rotação

    private void Update()
    {
        // Calcula a direção do objeto em movimento em relação a este objeto
        Vector3 directionToTarget = aviao.position - transform.position;

        // Calcula a rotação necessária para olhar para o objeto em movimento
        Quaternion targetRotation = Quaternion.LookRotation(directionToTarget);

        // Interpola suavemente a rotação atual para a rotação desejada
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, velocidadeRotacao * Time.deltaTime);
    }
}


