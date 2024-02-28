using UnityEngine;

public  class VisorCamera : MonoBehaviour
{
    [SerializeField] private Transform targetAviao;
    [SerializeField] private float velocidadeVisor;

    private void Update()
    {
        //calcula a distancia entre objeto e camera
        Vector3 directionTarget= targetAviao.position - transform.position;
        Debug.Log(directionTarget);

        //calcula a rotacao para olhar para o objeto
        Quaternion targetRotation = Quaternion.LookRotation(directionTarget);

        //olha o objeto de forma suave
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, velocidadeVisor * Time.deltaTime);
    }
}