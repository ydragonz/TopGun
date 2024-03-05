using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FocaNoAviao : MonoBehaviour
{
    [Header("Configurações do avião")]
    [SerializeField]public Transform aviao;   
    [SerializeField]public float velocidadeRotacao = 5.0f;

    [Header("Configurações de menssage")]
    [SerializeField]private string message = "Derrubando o inimigo";
    private bool mensagemMostrada = false;

    private void Update()
    {
        VerificaAlturaDoAviao();
    }

    private void Atirar()
    {
        Debug.Log(message);
    }
    private void VerificaAlturaDoAviao()
    {
        if (aviao != null)
        {
            TorpedoSegueAviao();
            float alturaDoTorpedo = transform.position.y;
            float alturaDoAviao = aviao.position.y;

            if (alturaDoAviao >= alturaDoTorpedo && !mensagemMostrada)
            {
                Debug.Log(message);
                mensagemMostrada = true;
            }
        }
    }
    /// <summary>
    /// Aqui o torpedo ira ficar olhando para o aviao.
    /// </summary>
    private void TorpedoSegueAviao()
    {
        transform.LookAt(aviao);
    }
}


