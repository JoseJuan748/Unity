using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextCtrl : MonoBehaviour
{
    [SerializeField] private TMP_Text textoVida;
    [SerializeField] private TMP_Text textoCoins;

    [SerializeField] private GameObject panelGO;

    public int Vida;
    public int coins;

    void Start()
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

            if (Vida <= 0)
            {
                panelGO.SetActive(true);
                panelGO.SetActive(false);

            }


        }

    }
}
