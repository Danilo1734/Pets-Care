using System.Collections.Generic;
using UnityEngine;

public class ScreenManager : MonoBehaviour
{

    [Header("Lista de Telas (Panels)")]
    public GameObject[] telas;

    private Stack<GameObject> historico = new Stack<GameObject>();
    private GameObject telaAtual;
   
    void Start()
    {
        if (telas.Length > 0)
        {
            AbrirTela(telas[0]);
        }
    }

    public void AbrirTela(GameObject novaTela)
    {
        if (telaAtual != null)
        {
            telaAtual.SetActive(false);
            historico.Push(telaAtual);
        }

        novaTela.SetActive(true);
        telaAtual = novaTela;
    }

    public void VoltarTela()
    {
        if (historico.Count > 0)
        {
            telaAtual.SetActive(false);
            telaAtual = historico.Pop();
            telaAtual.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
