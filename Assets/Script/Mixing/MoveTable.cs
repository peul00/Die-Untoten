using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTable : MonoBehaviour
{
    public float Range;
    public float Time;
    public GameObject Serving;
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
        iTween.MoveTo(gameObject, iTween.Hash("x", 3.5, "time", 5));
        iTween.MoveTo(Serving, iTween.Hash("x", -11, "time", 3));
        iTween.MoveTo(Customer, iTween.Hash("x", -5, "time", 3));
    }
    public void Close()
    {
        iTween.MoveTo(gameObject, iTween.Hash("x", 18, "time", 4));
        iTween.MoveTo(Serving, iTween.Hash("x", 0, "time", 2));
        iTween.MoveTo(Customer, iTween.Hash("x", 0, "time", 2));
    }
    public void mixer()
    {
        iTween.MoveTo(Mixer, iTween.Hash("x", Range, "time", Time));
    }
    public void shaker()
    {
        iTween.MoveTo(Shaker, iTween.Hash("x", Range, "time", Time));
    }
    public void stirring()
    {
        iTween.MoveTo(Stirring, iTween.Hash("x", Range, "time", Time));
    }
    public void choco()
    {
        iTween.MoveTo(Choco, iTween.Hash("y", 1.5, "time", Time));
        Choco.gameObject.SetActive(true);
        iTween.MoveTo(Cran, iTween.Hash("y", 3.5, "time", Time));
        Invoke("Cra", 2f);
        iTween.MoveTo(Melon, iTween.Hash("y", 3.5, "time", Time));
        Invoke("Mel", 2f);
        iTween.MoveTo(Orange, iTween.Hash("y", 3.5, "time", Time));
        Invoke("Ora", 2f);
        iTween.MoveTo(Honey, iTween.Hash("y", 3.5, "time", Time));
        Invoke("Hon", 2f);
    }
    public void cran()
    {
        iTween.MoveTo(Choco, iTween.Hash("y", 3.5, "time", Time));
        Invoke("Cho", 2f);
        iTween.MoveTo(Cran, iTween.Hash("y", 1.5, "time", Time));
        Cran.gameObject.SetActive(true);
        iTween.MoveTo(Melon, iTween.Hash("y", 3.5, "time", Time));
        Invoke("Mel", 2f);
        iTween.MoveTo(Orange, iTween.Hash("y", 3.5, "time", Time));
        Invoke("Ora", 2f);
        iTween.MoveTo(Honey, iTween.Hash("y", 3.5, "time", Time));
        Invoke("Hon", 2f);
    }
    public void melon()
    {
        iTween.MoveTo(Choco, iTween.Hash("y", 3.5, "time", Time));
        Invoke("Cho", 2f);
        iTween.MoveTo(Cran, iTween.Hash("y", 3.5, "time", Time));
        Invoke("Cra", 2f);
        iTween.MoveTo(Melon, iTween.Hash("y", 1.5, "time", Time));
        Melon.gameObject.SetActive(true);
        iTween.MoveTo(Orange, iTween.Hash("y", 3.5, "time", Time));
        Invoke("Ora", 2f);
        iTween.MoveTo(Honey, iTween.Hash("y", 3.5, "time", Time));
        Invoke("Hon", 2f);
    }

    public void orange()
    {
        iTween.MoveTo(Choco, iTween.Hash("y", 3.5, "time", Time));
        Invoke("Cho", 2f);
        iTween.MoveTo(Cran, iTween.Hash("y", 3.5, "time", Time));
        Invoke("Cra", 2f);
        iTween.MoveTo(Melon, iTween.Hash("y", 3.5, "time", Time));
        Invoke("Mel", 2f);
        iTween.MoveTo(Orange, iTween.Hash("y", 1.5, "time", Time));
        Orange.gameObject.SetActive(true);
        iTween.MoveTo(Honey, iTween.Hash("y", 3.5, "time", Time));
        Invoke("Hon", 2f);
    }
    public void honey()
    {
        iTween.MoveTo(Choco, iTween.Hash("y", 3.5, "time", Time));
        Invoke("Cho", 2f);
        iTween.MoveTo(Cran, iTween.Hash("y", 3.5, "time", Time));
        Invoke("Cra", 2f);
        iTween.MoveTo(Melon, iTween.Hash("y", 3.5, "time", Time));
        Invoke("Mel", 2f);
        iTween.MoveTo(Orange, iTween.Hash("y", 3.5, "time", Time));
        Invoke("Ora", 2f);
        iTween.MoveTo(Honey, iTween.Hash("y", 1.5, "time", Time));
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
