using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocarCena : MonoBehaviour
{

    [SerializeField] private string nomeCena;

    public void CarregarCena(string nomeCena)
    {
        SceneManager.LoadScene(nomeCena);
    }

    public void IrParaCasa()
    {
        SceneManager.LoadScene("CenaDaCasa");
    }

    public void IrParaLoja()
    {
        SceneManager.LoadScene("CenaDaLoja");
    }

    public void IrParaHospital()
    {
        SceneManager.LoadScene("CenaDeCura");
    }

    public void SelecaoDeFases()
    {
        SceneManager.LoadScene("CenaDeSelecaoDeFases");
    }

    public void SairDoJogo()
    {
        Application.Quit();
    }
}
