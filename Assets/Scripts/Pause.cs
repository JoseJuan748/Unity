using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    [SerializeField] GameObject pause;

    public void PauseButton()
    {
        pause.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        pause.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Home(int Menu)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(Menu);
    }
}
