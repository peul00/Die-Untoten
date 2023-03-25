using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

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

    private bool isDialogue = false;
    private bool isTyping = false;

    private int count = 0;

    [SerializeField] private Dialogue[] dialogue;


    void Start()
    {
        StartCoroutine(ShowDialogueAfterDelay(3.0f));
    }

    // 3초 후에 대화를 시작하는 코루틴을 추가합니다.
    IEnumerator ShowDialogueAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        ShowDialogue();
    }
    public void ShowDialogue()
    {
        OnOff(true);
        count = 0;
        StartCoroutine(_typing());
    }

    public void OnClickExit()
    {
        Application.Quit();
        Debug.Log("Exit");
    }

    private void OnOff(bool _flag)
    {
        isDialogue = _flag;
        sprite_DialogueBox.gameObject.SetActive(_flag);
        sprite_Npc1.gameObject.SetActive(_flag);
        txt_Dialogue.gameObject.SetActive(_flag);
    }

    IEnumerator _typing()
    {
        isTyping = true;
        string _dialogue = dialogue[count].dialogue;
        txt_Dialogue.text = "";

        for (int i = 0; i < _dialogue.Length; i++)
        {
            if (isTyping)
            {
                txt_Dialogue.text += _dialogue[i];
                yield return new WaitForSeconds(0.1f);
            }
            else
            {
                break;
            }
        }

        if (isTyping)
        {
            // 대화창이 완전히 나온 상태로 만들기
            txt_Dialogue.text = dialogue[count].dialogue;

            // 다음 대화로 넘어가는 코드
            if (count < dialogue.Length - 1)
            {
                count += 1;
                NextDialogue();
                StartCoroutine(_typing());
            }
            else
            {
                OnOff(false);
                SceneManager.LoadScene("InGame");
            }
        }
    }

    public void OnDialogueAdvance()
    {
        if (isTyping)
        {
            isTyping = false;
        }
        else
        {
            // 대화창이 이미 완전히 나온 상태에서 스페이스를 누르면 다음 대화창으로 넘어감
            if (count < dialogue.Length - 1)
            {
                count += 1;
                NextDialogue();
                StartCoroutine(_typing());
            }
            else
            {
                OnOff(false);
                SceneManager.LoadScene("InGame");
            }
        }
    }

    void NextDialogue()
    {
        Debug.Log("count : " + count);
        txt_Dialogue.text = dialogue[count].dialogue;
        sprite_Npc1.sprite = dialogue[count].npc;
    }

    void Update()
    {
        if (isDialogue)
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
            {
                OnDialogueAdvance();
            }
        }
    }
}
