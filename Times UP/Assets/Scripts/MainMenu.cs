using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string StartGame;
    public string Abspann;
    public string HomeMenu;




    public void Starten()
    {

        SceneManager.LoadScene(StartGame);
    }

    public void TitleMenu()
    {
        SceneManager.LoadScene(HomeMenu);
    }



    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

    public void OpenCredits()
    {
        SceneManager.LoadScene(Abspann);
    }


}