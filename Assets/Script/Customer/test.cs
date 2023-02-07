using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue
{
    [TextArea]
    public string dialogue;
    public Sprite npc;

}
public class test : MonoBehaviour
{
    [SerializeField] private SpriteRenderer sprite_Npc1;
    [SerializeField] private SpriteRenderer sprite_DialogueBox;
    [SerializeField] private Text txt_Dialogue;


    private bool isDialogue = false;

    private int count = 0;

    [SerializeField] private Dialogue[] dialogue;

    public void ShowDialogue()
    {
        OnOff(true);
        count = 0;
        NextDialogue();

    }
    
    private void NextDialogue()
    {
        txt_Dialogue.text = dialogue[count].dialogue;
        sprite_Npc1.sprite = dialogue[count].npc;
        count++;
    }
    


    private void OnOff(bool _flag)
    {
        sprite_DialogueBox.gameObject.SetActive(_flag);
        sprite_Npc1.gameObject.SetActive(_flag);
        txt_Dialogue.gameObject.SetActive(_flag);
    }

    private void Update()
    {
        if (isDialogue)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (count < dialogue.Length)
                {
                    NextDialogue();
                }
                else
                {
                    OnOff(false);
                    //isDialogue = false;
                }
            }
        }
    }

}
   

    
