using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;


/*[System.Serializable]
public class Dialogue
{
    [TextArea]
    public string dialogue;
    public Sprite npc;

}*/
public class Test1 : MonoBehaviour
{
    public void OnClickExit()
    {
        Application.Quit();
        Debug.Log("Exit");
    }

    /*public UnityEvent onInputSpace;
    [SerializeField] private SpriteRenderer sprite_Npc1;
    [SerializeField] private Image sprite_DialogueBox;
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
    private void OnOff(bool _flag)
    {
        sprite_DialogueBox.gameObject.SetActive(_flag);
        sprite_Npc1.gameObject.SetActive(_flag);
        txt_Dialogue.gameObject.SetActive(_flag);
    }

    private void NextDialogue()
    {
        txt_Dialogue.text = dialogue[count].dialogue;
        sprite_Npc1.sprite = dialogue[count].npc;
        count++;
    }
    


    

    void Update()
    {
        if (isDialogue)
        { 
            if (Input.GetKeyDown(KeyCode.Space))
            {
                onInputSpace.Invoke();
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
    }*/

}
   

    
