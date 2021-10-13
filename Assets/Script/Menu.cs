using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Aparecer(GameObject painel)
    {
        painel.SetActive(true);
    }

    public void Sumir(GameObject painel)
    {
        painel.SetActive(false);
    }

    public void MudarCena(string cena)
    {
        SceneManager.LoadScene(cena);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
