using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleSceneMain : BaseSceneMain
{
    public void OnStartButton()
    {
        Debug.Log("OnstartButton");

        SceneController.Instance.LoadScene(SceneNameConstants.LoadingScene);
        SceneController.Instance.LoadScene(SceneNameConstants.Scene1);
    }

}