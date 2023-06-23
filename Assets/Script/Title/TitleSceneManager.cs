using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleSceneManager : MonoBehaviour
{
    public void OnNewGameBtn()
    {
        Debug.Log("New Game");
        SceneManager.LoadScene("LoadingScene");
    }
    public void OnContinueBtn()
    {
        Debug.Log("Continue");
    }
    public void OnSettingsBtn()
    {
        Debug.Log("Settings");
    }
    public void OnExitBtn()
    {
        Debug.Log("Exit");
        Application.Quit();
    }
}