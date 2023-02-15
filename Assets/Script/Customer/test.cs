using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;


[System.Serializable]
public class Dialogue
{
    [TextArea]
    public string dialogue;
    public Sprite npc;

}
public class test : MonoBehaviour
{
    public UnityEvent onInputSpace;
    [SerializeField] private SpriteRenderer sprite_Npc1;
    [SerializeField] private Image sprite_DialogueBox;
    [SerializeField] private Text txt_Dialogue;

    public void ShowDialogue()
    {
        OnOff(true);
        count = 0;
        NextDialogue();
    }

    public void OnClickExit() {
        Application.Quit();
        Debug.Log("Exit");
    }


    
    private bool isDialogue = false;
    
    private int count = 0;

    [SerializeField] private Dialogue[] dialogue;

    
    private void OnOff(bool _flag)
    {
        isDialogue = _flag;
        sprite_DialogueBox.gameObject.SetActive(_flag);
        sprite_Npc1.gameObject.SetActive(_flag);
        txt_Dialogue.gameObject.SetActive(_flag);
    }

    void NextDialogue()
    {
        Debug.Log("count : " + count);
        txt_Dialogue.text = dialogue[count].dialogue;
        sprite_Npc1.sprite = dialogue[count].npc;
        count += 1;
    }
    


    

    void Update()
    {
        Debug.Log("update");
        if (isDialogue)
        {
            Debug.Log("1");
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("2");
                onInputSpace.Invoke();
                if (count < dialogue.Length)
                {
                    Debug.Log("3");
                    NextDialogue();
                    
                }
                else
                {
                    Debug.Log("4");
                    OnOff(false);
                    //isDialogue = false;
                }
            }
        }
        
    }

}
