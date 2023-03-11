using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextDay : MonoBehaviour
{
    public void Rest()
    {
        SceneManager.LoadScene("LoadingScene");
    }
}
