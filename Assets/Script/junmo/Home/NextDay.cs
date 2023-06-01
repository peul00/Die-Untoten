using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextDay : MonoBehaviour
{
    public GameObject Fade;
    public void Rest()
    {
        Fade.SetActive(true);
        Invoke("Chan", 3f);
        GameManager.instance.DDay();
    }
    public void Chan()
    {
        SceneManager.LoadScene("LoadingScene");
    }
}
