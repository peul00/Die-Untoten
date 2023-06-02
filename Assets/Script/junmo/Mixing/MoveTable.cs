using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTable : MonoBehaviour
{
    public float Time;
    public GameObject Customer;
    public GameObject Mixer;
    public GameObject Shaker;
    public GameObject Stirring;
    public GameObject Choco;
    public GameObject Cran;
    public GameObject Melon;
    public GameObject Orange;
    public GameObject Honey;

    public void Start()
    {

    }

    public void Open()
    {
        iTween.MoveTo(Customer, iTween.Hash("x", -6, "time", 2));
    }
    public void Close()
    {
        iTween.MoveTo(Customer, iTween.Hash("x", -5, "time", 2));
    }
    public void mixer()
    {
        iTween.MoveTo(Mixer, iTween.Hash("x", 7, "time", Time));
        iTween.MoveTo(Shaker, iTween.Hash("x", 12, "time", Time));
        iTween.MoveTo(Stirring, iTween.Hash("x", 12, "time", Time));
        if(Mixer.transform.position.x == 7)
        {
            iTween.MoveTo(Mixer, iTween.Hash("x", 12, "time", Time));
            iTween.MoveTo(Shaker, iTween.Hash("x", 12, "time", Time));
            iTween.MoveTo(Stirring, iTween.Hash("x", 12, "time", Time));
        }
    }
    public void shaker()
    {
        iTween.MoveTo(Mixer, iTween.Hash("x", 12, "time", Time));
        iTween.MoveTo(Shaker, iTween.Hash("x", 7, "time", Time));
        iTween.MoveTo(Stirring, iTween.Hash("x", 12, "time", Time));
        if (Shaker.transform.position.x == 7)
        {
            iTween.MoveTo(Mixer, iTween.Hash("x", 12, "time", Time));
            iTween.MoveTo(Shaker, iTween.Hash("x", 12, "time", Time));
            iTween.MoveTo(Stirring, iTween.Hash("x", 12, "time", Time));
        }
    }
    public void stirring()
    {
        iTween.MoveTo(Mixer, iTween.Hash("x", 12, "time", Time));
        iTween.MoveTo(Shaker, iTween.Hash("x", 12, "time", Time));
        iTween.MoveTo(Stirring, iTween.Hash("x", 7, "time", Time));
        if (Stirring.transform.position.x == 7)
        {
            iTween.MoveTo(Mixer, iTween.Hash("x", 12, "time", Time));
            iTween.MoveTo(Shaker, iTween.Hash("x", 12, "time", Time));
            iTween.MoveTo(Stirring, iTween.Hash("x", 12, "time", Time));
        }
    }
    public void choco()
    {
        iTween.MoveTo(Choco, iTween.Hash("y", 1.5, "time", Time));
        Choco.gameObject.SetActive(true);
        iTween.MoveTo(Cran, iTween.Hash("y", 3.5, "time", Time));
        Invoke("Cra", 1f);
        iTween.MoveTo(Melon, iTween.Hash("y", 3.5, "time", Time));
        Invoke("Mel", 1f);
        iTween.MoveTo(Orange, iTween.Hash("y", 3.5, "time", Time));
        Invoke("Ora", 1f);
        iTween.MoveTo(Honey, iTween.Hash("x", 8, "time", Time));
        Invoke("Hon", 1f);
    }
    public void cran()
    {
        iTween.MoveTo(Choco, iTween.Hash("y", 3.5, "time", Time));
        Invoke("Cho", 1f);
        iTween.MoveTo(Cran, iTween.Hash("y", 1.5, "time", Time));
        Cran.gameObject.SetActive(true);
        iTween.MoveTo(Melon, iTween.Hash("y", 3.5, "time", Time));
        Invoke("Mel", 1f);
        iTween.MoveTo(Orange, iTween.Hash("y", 3.5, "time", Time));
        Invoke("Ora", 1f);
        iTween.MoveTo(Honey, iTween.Hash("x", 8, "time", Time));
        Invoke("Hon", 1f);
    }
    public void melon()
    {
        iTween.MoveTo(Choco, iTween.Hash("y", 3.5, "time", Time));
        Invoke("Cho", 1f);
        iTween.MoveTo(Cran, iTween.Hash("y", 3.5, "time", Time));
        Invoke("Cra", 1f);
        iTween.MoveTo(Melon, iTween.Hash("y", 1.5, "time", Time));
        Melon.gameObject.SetActive(true);
        iTween.MoveTo(Orange, iTween.Hash("y", 3.5, "time", Time));
        Invoke("Ora", 1f);
        iTween.MoveTo(Honey, iTween.Hash("x", 8, "time", Time));
        Invoke("Hon", 1f);
    }

    public void orange()
    {
        iTween.MoveTo(Choco, iTween.Hash("y", 3.5, "time", Time));
        Invoke("Cho", 1f);
        iTween.MoveTo(Cran, iTween.Hash("y", 3.5, "time", Time));
        Invoke("Cra", 1f);
        iTween.MoveTo(Melon, iTween.Hash("y", 3.5, "time", Time));
        Invoke("Mel", 1f);
        iTween.MoveTo(Orange, iTween.Hash("y", 1.5, "time", Time));
        Orange.gameObject.SetActive(true);
        iTween.MoveTo(Honey, iTween.Hash("x", 8, "time", Time));
        Invoke("Hon", 1f);
    }
    public void honey()
    {
        iTween.MoveTo(Choco, iTween.Hash("y", 3.5, "time", Time));
        Invoke("Cho", 1f);
        iTween.MoveTo(Cran, iTween.Hash("y", 3.5, "time", Time));
        Invoke("Cra", 1f);
        iTween.MoveTo(Melon, iTween.Hash("y", 3.5, "time", Time));
        Invoke("Mel", 1f);
        iTween.MoveTo(Orange, iTween.Hash("y", 3.5, "time", Time));
        Invoke("Ora", 1f);
        iTween.MoveTo(Honey, iTween.Hash("x", 6, "time", Time));
        Honey.gameObject.SetActive(true);
    }
    void Cho()
    {
        Choco.gameObject.SetActive(false);
    }
    void Cra()
    {
        Cran.gameObject.SetActive(false);
    }
    void Mel()
    {
        Melon.gameObject.SetActive(false);
    }
    void Ora()
    {
        Orange.gameObject.SetActive(false);
    }
    void Hon()
    {
        Honey.gameObject.SetActive(false);
    }
}
