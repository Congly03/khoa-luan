using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject selectCharacter;
    public GameObject mainMenu;

    public void OnSelectCharacter()
    {
        selectCharacter.SetActive(true);
        mainMenu.SetActive(false);
    }

    public void OnPlayButton()
    {
        SceneManager.LoadScene("ZombieLand");
    }

    public void OnQuiButton()
    {
        Debug.Log("Quitting Game...");
        Application.Quit();
    }
}
