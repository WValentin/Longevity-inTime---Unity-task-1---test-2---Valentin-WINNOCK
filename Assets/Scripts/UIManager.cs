using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject menu;
    public GameObject appUI;

    public void OpenMenu()
    {
        appUI.SetActive(false);
        menu.SetActive(true);
    }

    public void CloseMenu()
    {
        menu.SetActive(false);
        appUI.SetActive(true);
    }

    public void ReturnToMainMenu()
    {
        menu.SetActive(false);
        mainMenu.SetActive(true);
    }

    public void StartApp()
    {
        mainMenu.SetActive(false);
        appUI.SetActive(true);
    }

    public void ExitApp()
    {
        Application.Quit();
    }
}
