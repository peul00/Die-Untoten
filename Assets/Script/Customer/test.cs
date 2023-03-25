using JetBrains.Annotations;
using System;
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

[System.Serializable]
public class DateDialogue
{
    public string date;
    public Dialogue[] dialogue;
}

public class Test : MonoBehaviour
{
    public UnityEvent onInputSpace;
    [SerializeField] private SpriteRenderer sprite_Npc1;
    [SerializeField] private Image sprite_DialogueBox;
    [SerializeField] private Text txt_Dialogue;
    [SerializeField] private Dialogue[] dialogue;
    public DateDialogue[] dateDialogues;
    
    private bool isDialogue = false;
    private bool isTyping = false;
    private bool isDateDialogue = false;
    private float timer = 0.0f;

    private int count = 0;

    [SerializeField] private DateDialogue[] dateDialogue;

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
        string _dialogue = dateDialogue[GetCurrentDateIndex()].dialogue[count].dialogue;
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
            // ��ȭâ�� ������ ���� ���·� �����
            txt_Dialogue.text = dateDialogue[GetCurrentDateIndex()].dialogue[count].dialogue;

            // ���� ��ȭ�� �Ѿ�� �ڵ�
            if (count < dateDialogue[GetCurrentDateIndex()].dialogue.Length - 1)
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
            // ��ȭâ�� �̹� ������ ���� ���¿��� �����̽��� ������ ���� ��ȭâ���� �Ѿ
            if (count < dateDialogue[GetCurrentDateIndex()].dialogue.Length - 1)
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
        txt_Dialogue.text = dateDialogue[GetCurrentDateIndex()].dialogue[count].dialogue;
        sprite_Npc1.sprite = dateDialogue[GetCurrentDateIndex()].dialogue[count].npc;
    }

    void Update()
    {
        // ��ȭâ�� �����ִ� ���ȿ��� �Է��� ����
        if (isDialogue)
        {
            // Space bar �Ǵ� ��Ŭ������ ��ȭ ����
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
            {
                OnDialogueAdvance();
            }
        }

        // 3�� �ڿ� ShowDateDialogue �Լ� ����
        if (!isDialogue && !isDateDialogue)
        {
            timer += Time.deltaTime;
            if (timer >= 3.0f)
            {
                ShowDateDialogue();
                timer = 0.0f;
            }
        }
    }
    private int GetCurrentDateIndex()
    {
        int index = -1;

        // ���� �ý��� ��¥�� ���� ��¥�� ���� ��ȭ �������� �ε����� ã��
        for (int i = 0; i < dateDialogues.Length; i++)
        {
            if (dateDialogues[i].date == System.DateTime.Now.ToString("yyyyMMdd"))
            {
                index = i;
                break;
            }
        }

        if (index == -1)
        {
            Debug.LogError("��ȭ �����͸� ã�� �� �����ϴ�.");
        }

        return index;
    }
    public void ShowDateDialogue()
    {
        int index = GetCurrentDateIndex();
        if (index != -1)
        {
            OnOff(true);
            count = 0;
            dialogue = dateDialogues[index].dialogue;
            StartCoroutine(_typing());
        }
        else
        {
            Debug.Log("No dialogue for current date.");
        }
    }
    void Start()
    {
        dateDialogues = FindObjectOfType<DateDialogueManager>().DateDialogue;
    }
}