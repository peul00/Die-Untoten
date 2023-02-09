using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyIce : MonoBehaviour
{
    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Mix")
        {
            if (Input.GetMouseButton(0) == false)
            {
                Destroy(gameObject);
            }
        }
    }
}
