using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeOut : MonoBehaviour
{
    [SerializeField]
    [Range(0.01f, 10f)]
    private float fadeTime;
    private Image image;

    public void Awake()
    {
        image = GetComponent<Image>();
        StartCoroutine(Fade(1, 0));
        Invoke("Off", fadeTime);
    }
    private IEnumerator Fade(float start, float end)
    {
        float currentTime = 0.0f;
        float percent = 0.0f;

        while (percent < 1)
        {
            currentTime += Time.deltaTime;
            percent = currentTime / fadeTime;

            Color color = image.color;
            color.a = Mathf.Lerp(start, end, percent);
            image.color = color;

            yield return null;
        }
    }

    public void Out()
    {
        image = GetComponent<Image>();
        StartCoroutine(Fade(0, 1));
    }

    void On()
    {
        gameObject.SetActive(true);
    }

    void Off()
    {
        gameObject.SetActive(false);
    }
}
