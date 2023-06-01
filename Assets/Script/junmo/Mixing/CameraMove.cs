using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public void Left()
    {
        iTween.MoveTo(gameObject, iTween.Hash("x", -20, "time", 4));
    }
    public void Right()
    {
        iTween.MoveTo(gameObject, iTween.Hash("x", 0, "time", 4));
    }
}
