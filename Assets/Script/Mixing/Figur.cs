using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Figur : MonoBehaviour
{
    public Sprite[] figur = new Sprite[3];
    public SpriteRenderer Img_Renderer;
    public int RandomFigur;

    public void OnEnable()
    {
        RandomFigur = Random.Range(0, 6);
        if (RandomFigur == 0)
        {
            Img_Renderer.sprite = figur[0];
        }
        else if(RandomFigur == 1)
        {
            Img_Renderer.sprite = figur[1];
        }
        else if (RandomFigur == 2)
        {
            Img_Renderer.sprite = figur[2];
        }
        else if (RandomFigur == 3)
        {
            Img_Renderer.sprite = figur[3];
        }
        else if (RandomFigur == 4)
        {
            Img_Renderer.sprite = figur[4];
        }
        else if (RandomFigur == 5)
        {
            Img_Renderer.sprite = figur[5];
        }
    }
}
