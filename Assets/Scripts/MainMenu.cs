using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject settingsMenu;
    public GameObject levelMenu;
    public void startGame()
    {
        SceneManager.LoadScene(1);
    }

    public void OpenSettings()
    {
        settingsMenu.SetActive(true);
    }
    public void CloseSettings()
    {
        settingsMenu.SetActive(false);
    }
    public void OpenLevelMenu()
    {
        levelMenu.SetActive(true);
    }
    public void CloseLevelMenu()
    {
        levelMenu.SetActive(false);
    }
    public void exitGame()
    {
        Debug.Log("Exiting...");
        Application.Quit();
    }
}
