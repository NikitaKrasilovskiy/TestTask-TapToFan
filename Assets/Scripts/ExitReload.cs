using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitReload : MonoBehaviour
{
    public void Reload()
    {
        SceneManager.LoadScene(0);
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void Start()
    {
        Time.timeScale = 1;
    }
}
