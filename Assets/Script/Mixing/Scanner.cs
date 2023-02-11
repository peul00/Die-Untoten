using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scanner : MonoBehaviour
{
    public bool scanner = false;
    public void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Serving")
        {
            scanner = true;
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Serving")
        {
            scanner = false;
        }
    }

}
