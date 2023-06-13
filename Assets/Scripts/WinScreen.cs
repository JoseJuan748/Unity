using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour
{
    [SerializeField] private GameObject restartButton;

    // Método para reiniciar el nivel
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // Método para activar el botón de reinicio
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