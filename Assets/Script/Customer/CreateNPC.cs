/*using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Dialogue
{
    [TextArea]
    public string dialogu;
    public Sprite Npc;

}

public class CreateNPC : MonoBehaviour
{
    [SerializeField] private SpriteRenderer sprite_Npc1;
    [SerializeField] private Image sprite_DialogueBox;
    [SerializeField] private Text txt_Dialogue;

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
        txt_Dialogue.text = dialogue[count].dialogu;
        sprite_Npc1.sprite = dialogue[count].Npc;
        count++;
    }

    void Update()
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
            }
        }
    }
    

}

*/

