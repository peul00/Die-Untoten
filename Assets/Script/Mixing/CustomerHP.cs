using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomerHP : MonoBehaviour
{
    public float HP;
    public float CurrentHP;
    public float Endu;
    public float CurrentEndu;
    public Slider Hpbar;
    public Slider Endubar;

    private void OnEnable()
    {
        HP = Random.Range(100, 1001);
        CurrentHP = HP;
        Endu = Random.Range(60, 121);
        CurrentEndu = Random.Range(30, Endu);
        
    }
    void Update()
    {
        Hpbar.value = CurrentHP / HP;
        Endubar.value = CurrentEndu / Endu;
        CurrentEndu -= Time.deltaTime;
        if(CurrentEndu <= 0)
        {
            gameObject.SetActive(false);
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        CurrentHP -= OnDrag.Tip;
        CurrentEndu += OnDrag.Tip / 10;
        if (CurrentHP <= OnDrag.Tip)
        {
            gameObject.SetActive(false);
        }
    }
}
