/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DateDialoguess
{
    public string date;
    public Dialogue[] dialogue;

}

public class DateDialogueManager : MonoBehaviour
{
    public static DateDialogueManager instance;

    public DateDialoguess[] dateDialogues;

    private int currentDateIndex = 0;
    public DateDialogue[] dteDialogues;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }

    public int GetCurrentDateIndex()
    {
        return currentDateIndex;
    }

    public void SetCurrentDateIndex(int index)
    {
        currentDateIndex = index;
    }

    public Dialogue[] GetDialogueByCurrentDate()
    {
        return dateDialogues[currentDateIndex].dialogue;
    }
    public DateDialogue GetDateDialogue(int index)
    {
        if (index >= dateDialogues.Length || index < 0)
        {
            return null;
        }

        return dteDialogues[index];
    }
}


*/