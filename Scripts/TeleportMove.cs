using UnityEngine;
using UnityEngine.Rendering;

public class TeleportMove : MonoBehaviour
{

    public float velocidade = 5f;
    public float limiteDireita = 10f;
    public float limiteEsquerda = -10f;
    public bool moverParaDireita = true;
    
    void Update()
    {
        float direcao = moverParaDireita ? 1f : -1f;

        transform.Translate(Vector3.right * direcao * velocidade * Time.deltaTime);

        if (moverParaDireita && transform.position.x > limiteDireita)
        {
            transform.position = new Vector3(limiteEsquerda, transform.position.y, transform.position.z);
        }

        if (!moverParaDireita && transform.position.x < limiteEsquerda)
        { 
            transform.position = new Vector3(limiteDireita, transform.position.y,transform.position.z);
        }
    }
}
