using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Menu : MonoBehaviour
{
    private bool isPaused = false;

    public GameObject mainMenu;
    public GameObject menuPerdedor;

    public Player playerScript;

    private void Start()
    {
        Time.timeScale = 0;
    }

    public void Iniciar()
    {
        playerScript.vidas = 3;
        Time.timeScale = 1;
        mainMenu.SetActive(false);
    }

    public void Salir()
    {
        EditorApplication.isPlaying = false;
    }

    public void Perdiste()
    {
        menuPerdedor.SetActive(true);
        Time.timeScale = 0;
    }

    public void Reiniciar()
    {
        playerScript.vidas = 3;
        Time.timeScale = 1;
        mainMenu.SetActive(false);
        menuPerdedor.SetActive(false);
    }

    public void ToMainMenu()
    {
        Time.timeScale = 0;
        menuPerdedor.SetActive(false);
        mainMenu.SetActive(true);
    }
}
