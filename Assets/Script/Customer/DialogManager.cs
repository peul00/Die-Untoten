using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogManager : MonoBehaviour
{
    public GameObject talkPanel;
    public Text talkText;
    public GameObject scanObject;

    public void Action(GameObject scan0bj)
    {
        talkPanel.SetActive(true);
        scanObject = scan0bj;
        talkText.text = "이것의 이름은 " + scanObject.name + "이라고한다 ";
    }



}
