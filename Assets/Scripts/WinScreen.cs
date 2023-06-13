using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour
{
    [SerializeField] private GameObject restartButton;

    // M�todo para reiniciar el nivel
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // M�todo para activar el bot�n de reinicio
    public void ActivateRestartButton()
    {
        restartButton.SetActive(true);
    }

    public void Home(int Menu)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(Menu);
    }

}