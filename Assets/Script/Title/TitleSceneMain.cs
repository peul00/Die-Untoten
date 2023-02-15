using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleSceneMain : BaseSceneMain
{
    public void OnNewGameBtn()
    {
        Debug.Log("New Game");

        SceneController.Instance.LoadScene(SceneNameConstants.LoadingScene);
        SceneController.Instance.LoadScene(SceneNameConstants.Customer);
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
    }

}