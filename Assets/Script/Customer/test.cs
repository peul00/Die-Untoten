/*using JetBrains.Annotations;
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
                    SceneManager.LoadScene("InGame");
                    //isDialogue = false;
                }
            }
        }
        
    }

}*/
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
<<<<<<< HEAD

[System.Serializable]
public class DateDialogue
{
    public string date;
    public Dialogue[] dialogue;
}

public class Test : MonoBehaviour
=======
public class test : MonoBehaviour
>>>>>>> parent of b4da776 (Customer System 1.2.1)
{
    public UnityEvent onInputSpace;
    [SerializeField] private SpriteRenderer sprite_Npc1;
    [SerializeField] private Image sprite_DialogueBox;
    [SerializeField] private Text txt_Dialogue;
<<<<<<< HEAD
    [SerializeField] private Dialogue[] dialogue;
    public DateDialogue[] dateDialogues;
    
    private bool isDialogue = false;
    private bool isTyping = false;
    private bool isDateDialogue = false;
    private float timer = 0.0f;

    private int count = 0;

    [SerializeField] private DateDialogue[] dateDialogue;
=======
>>>>>>> parent of b4da776 (Customer System 1.2.1)

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

    IEnumerator _typing()
    {
<<<<<<< HEAD
        isTyping = true;
        string _dialogue = dateDialogue[GetCurrentDateIndex()].dialogue[count].dialogue;
=======
        string _dialogue = dialogue[count].dialogue;
>>>>>>> parent of b4da776 (Customer System 1.2.1)
        txt_Dialogue.text = "";

        for (int i = 0; i < _dialogue.Length; i++)
        {
            txt_Dialogue.text += _dialogue[i];
            yield return new WaitForSeconds(0.1f);
        }

        // 다음 대화로 넘어가는 코드
        if (count < dialogue.Length)
        {
<<<<<<< HEAD
            // 대화창이 완전히 나온 상태로 만들기
            txt_Dialogue.text = dateDialogue[GetCurrentDateIndex()].dialogue[count].dialogue;

            // 다음 대화로 넘어가는 코드
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
            // 대화창이 이미 완전히 나온 상태에서 스페이스를 누르면 다음 대화창으로 넘어감
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
=======
            count += 1;
            NextDialogue();
            StartCoroutine(_typing());
        }
        else
        {
            OnOff(false);
            SceneManager.LoadScene("InGame");
>>>>>>> parent of b4da776 (Customer System 1.2.1)
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
        // 대화창이 열려있는 동안에만 입력을 받음
        if (isDialogue)
        {
<<<<<<< HEAD
            // Space bar 또는 좌클릭으로 대화 진행
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
=======
            if (Input.GetKeyDown(KeyCode.Space))
>>>>>>> parent of b4da776 (Customer System 1.2.1)
            {
                onInputSpace.Invoke();
            }
        }

        // 3초 뒤에 ShowDateDialogue 함수 실행
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
<<<<<<< HEAD
    private int GetCurrentDateIndex()
    {
        int index = -1;

        // 현재 시스템 날짜와 같은 날짜를 가진 대화 데이터의 인덱스를 찾음
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
            Debug.LogError("대화 데이터를 찾을 수 없습니다.");
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
=======

}
>>>>>>> parent of b4da776 (Customer System 1.2.1)
