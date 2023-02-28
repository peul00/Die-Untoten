using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    float Timer;
    float Waiting;
    void Start()
    {
        Timer = 0.0f;
        Waiting = 3.0f;
        StartCoroutine(SiZe());
    }
    void Update()
    {
        Timer += Time.deltaTime;
    }

    IEnumerator SiZe()
    {
        while (true)
        {
            Size();
            yield return new WaitForSecondsRealtime(0.05f);
            if(Timer > Waiting)
            {
                break;
            }
        }
    }

    void Size()
    {
        Vector3 scale = Vector3.zero;
        scale.x = 0.05f;
        transform.localScale += scale;
        Debug.Log("aaaa");
    }
}
