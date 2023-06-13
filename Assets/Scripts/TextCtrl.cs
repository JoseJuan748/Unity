using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextCtrl : MonoBehaviour
{
    [SerializeField] private TMP_Text textoVida;
    [SerializeField] private TMP_Text textoCoins;
    [SerializeField] private GameObject perdiste;
    [SerializeField] private GameObject ganaste;

    [SerializeField] private GameObject panelGO;
    [SerializeField] private GameObject restartButton;
    [SerializeField] private GameObject individualRestartButton;

    public int Vida;
    public int coins;
    private bool hasWon = false;

    void Awake()
    {
        Time.timeScale = 1.0f;
    }
    private void Start()
    {
        Vida = 100;
        textoVida.text = " " + Vida.ToString();
        textoCoins.text = " " + coins.ToString();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "moneda")
        {
            coins += 10;
            textoCoins.text = "Coins: " + coins.ToString();
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "Enemigo 1")
        {
            Vida -= 10;
            textoVida.text = ": " + Vida.ToString();
            Destroy(collision.gameObject);

            CheckAlive();
        }

        if (collision.gameObject.tag == "Pinchos")
        {
            Vida -= 10;
            textoVida.text = ": " + Vida.ToString();

            CheckAlive();
        }
    }

    public void UpdateHealth()
    {
        Vida -= 10;
        textoVida.text = ": " + Vida.ToString();
        CheckAlive();
    }

    private void CheckAlive()
    {
        if (Vida <= 0)
        {
            panelGO.SetActive(false);
            perdiste.SetActive(true);
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("WinTrigger"))
        {
            WinGame();
        }
    }

    private void WinGame()
    {
        panelGO.SetActive(false);
        ganaste.SetActive(true);
        Time.timeScale = 0f; // Opcional: Pausar el juego al ganar
        individualRestartButton.SetActive(false); // Desactivar el botón de reinicio individual
        SceneManager.LoadScene("PanelGanaste"); // Cargar la escena del panel "Ganaste"
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}